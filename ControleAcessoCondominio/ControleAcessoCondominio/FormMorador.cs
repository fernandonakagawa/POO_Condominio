using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcessoCondominio
{
    public partial class FormMorador : Form
    {
        private FormPainelDeControle formPainelDeControle;
        public FormMorador(FormPainelDeControle formPainelDeControle)
        {
            InitializeComponent();
            this.formPainelDeControle = formPainelDeControle;
        }

        private void FormMorador_Load(object sender, EventArgs e)
        {
            AtualizarMoradores();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPainelDeControle.Show();
            formPainelDeControle.Atualizar();
            this.Hide();
        }

        private void btAdicionarMorador_Click(object sender, EventArgs e)
        {
            if(tbNome.Text.Length > 0 && tbCpf.Text.Length >0 
                && tbSenha.Text.Length >= Morador.TAM_MIN_SENHA)
            {
                string nome = tbNome.Text;
                string cpf = tbCpf.Text;
                string senha = tbSenha.Text;
                Morador m = new Morador(nome, cpf, senha);
                if (Condominio.Self.AdicionarMorador(m))
                {
                    ListViewItem item = new ListViewItem(nome);
                    item.SubItems.Add(cpf);
                    item.SubItems.Add("Sim");
                    lvMoradores.Items.Add(item);
                    MessageBox.Show("Morador adicionado com sucesso!");
                    tbNome.Text = "";
                    tbCpf.Text = "";
                    tbSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar morador!");
                }

                //inserir no banco
                try{Banco.InserirMorador(m);}
                catch(Exception exception)
                {
                    Banco.FecharConexao();
                    MessageBox.Show($"Erro ao adicionar morador no banco! {exception}");
                }
                
                try { AtualizarMoradores(); }
                catch(Exception exception) 
                {
                    Banco.FecharConexao();
                    MessageBox.Show($"Erro ao obter moradores no banco! {exception}"); 
                }
            }
            else
            {
                MessageBox.Show("Dados incompletos ou senha com menos de 6 caracteres!");
            }
        }

        private void AtualizarMoradores(SqlDataAdapter adaptador = null, 
            string textoLabel = "TODOS os moradores:")
        {
            if(adaptador == null) adaptador = Banco.SelectMoradores();

            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            //Populando a DataGridView
            dgvMoradores.DataSource = tabela;

            //Populando a ListView
            lvMoradores.Items.Clear();
            //Atualizando a list de moradores de Condomínio
            //Condominio.Self.Moradores.Clear();
            
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow drow = tabela.Rows[i];
                if (drow.RowState != DataRowState.Deleted)
                {
                    string nome = drow["Nome"].ToString();
                    string cpf = drow["Cpf"].ToString();
                    bool isAtivo = (bool)drow["IsAtivo"];
                    ListViewItem lvi = new ListViewItem(nome);
                    lvi.SubItems.Add(cpf);
                    lvi.SubItems.Add(isAtivo.ToString());

                    lvMoradores.Items.Add(lvi);

                    //Atualizando o Condomínio
                    Morador morador;
                    morador = Condominio.Self.BuscarMorador(cpf);
                    if (morador != null)
                    {
                        morador.Nome = nome;
                        morador.IsAtivo = isAtivo;
                    }
                    else
                    {
                        morador = new Morador(nome, cpf, "");
                        morador.IsAtivo = isAtivo;
                        Condominio.Self.AdicionarMorador(morador);
                    }
                }
            }

            lbBusca.Text = textoLabel;
        }

        private void btAtivarMorador_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                //int indice = lvMoradores.SelectedIndices[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if(m != null)
                {
                    Condominio.Self.AtivarMorador(m, !m.IsAtivo);
                    if (m.IsAtivo) itemMorador.SubItems[2].Text = "Sim";
                    else itemMorador.SubItems[2].Text = "Não";
                }

            }
            btAtivarMorador.Enabled = false;
            btMudarSenha.Enabled = false;
        }

        private void lvMoradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                btAtivarMorador.Enabled = true ;
                btMudarSenha.Enabled = true;
            }
            else
            {
                btAtivarMorador.Enabled = false;
                btMudarSenha.Enabled = false;
            }
        }

        private void btMudarSenha_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                lbNovaSenha.Visible = true;
                tbNovaSenha.Visible = true;
                btOkNovaSenha.Visible = true;
                btAtivarMorador.Enabled = false;
                btMudarSenha.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btOkNovaSenha_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                //int indice = lvMoradores.SelectedIndices[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    if (m.MudarSenha(tbNovaSenha.Text)) MessageBox.Show("Senha modificada com sucesso!");
                    else MessageBox.Show("A senha precisa ter mais de 6 dígitos");
                }
                lbNovaSenha.Visible = false;
                tbNovaSenha.Visible = false;
                btOkNovaSenha.Visible = false;
                btAtivarMorador.Enabled = false;
                btMudarSenha.Enabled = false;
                tbNovaSenha.Text = "";
            }
        }

        private void btBuscarMoradorNome_Click(object sender, EventArgs e)
        {
            string nome = tbBuscaNome.Text;
            lbBusca.Text = $"Resultados da busca pelo nome {nome}:";
            try
            {
                SqlDataAdapter adaptador = Banco.BuscarMoradores(nome);
                AtualizarMoradores(adaptador, $"Resultados da busca por {nome}:");
            }
            catch(Exception exception)
            {
                Banco.FecharConexao();
                MessageBox.Show($"Erro ao buscar morador! {exception.ToString()}");
            }

        }

        private void FormMorador_Shown(object sender, EventArgs e)
        {
            AtualizarMoradores();
        }

        private void dgvMoradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btMudarSenhaDgv_Click(object sender, EventArgs e)
        {
            if (dgvMoradores.SelectedCells.Count > 0)
            {
                lbNovaSenhaDgv.Visible = true;
                tbNovaSenhaDgv.Visible = true;
                btOkNovaSenhaDgv.Visible = true;
                btAtivarMoradorDgv.Enabled = false;
                btMudarSenhaDgv.Enabled = false;
                dgvMoradores.Enabled = false;
            }
        }

        private void FormMorador_VisibleChanged(object sender, EventArgs e)
        {
            AtualizarMoradores();
        }

        private void btOkNovaSenhaDgv_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(dgvMoradores.SelectedCells.Count);
            if (dgvMoradores.SelectedCells.Count > 0)
            {
               
                DataGridViewRow itemMorador = dgvMoradores.SelectedCells[0].OwningRow;
                Debug.WriteLine(itemMorador.Cells[1].Value.ToString());
                string cpf = itemMorador.Cells[1].Value.ToString();
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    try
                    {
                        if (Banco.MudarSenhaMorador(m, tbNovaSenhaDgv.Text) > 0 &&
                            m.MudarSenha(tbNovaSenhaDgv.Text))
                        {
                            MessageBox.Show("Senha modificada com sucesso!");
                            
                        }
                        else MessageBox.Show("A senha precisa ter mais de 6 dígitos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao mudar a senha. {ex.ToString()}");
                    }

                }
                else
                {
                    MessageBox.Show("Morador não encontrado.");
                }
                lbNovaSenhaDgv.Visible = false;
                tbNovaSenhaDgv.Visible = false;
                btOkNovaSenhaDgv.Visible = false;
                btAtivarMoradorDgv.Enabled = false;
                btMudarSenhaDgv.Enabled = false;
                tbNovaSenhaDgv.Text = "";
                dgvMoradores.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void dgvMoradores_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dgvMoradores_SelectionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(dgvMoradores.SelectedCells.Count);
            if (dgvMoradores.SelectedCells.Count > 0)
            {
                btAtivarMoradorDgv.Enabled = true;
                btMudarSenhaDgv.Enabled = true;
            }
            else
            {
                btAtivarMoradorDgv.Enabled = false;
                btMudarSenhaDgv.Enabled = false;
            }
        }

        private void dgvMoradores_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Debug.WriteLine("cellbeginedit");
            //Debug.WriteLine(dgvMoradores.SelectedCells.Count);
            if (dgvMoradores.SelectedCells.Count > 0)
            {

                DataGridViewRow itemMorador = dgvMoradores.SelectedCells[0].OwningRow;
                Debug.WriteLine(itemMorador.Cells[2].Value.ToString());
                string cpf = itemMorador.Cells[1].Value.ToString();
                bool isAtivo = (bool)itemMorador.Cells[2].Value;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    try
                    {
                        if (Banco.MudarIsAtivoMorador(m, isAtivo) > 0)
                        {
                            m.IsAtivo = isAtivo;
                            MessageBox.Show("Estado modificado com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao mudar o estado. {ex.ToString()}");
                    }

                }
                else
                {
                    MessageBox.Show("Morador não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }
    }
}
