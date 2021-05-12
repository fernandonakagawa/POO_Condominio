using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                catch(Exception exception){MessageBox.Show($"Erro ao adicionar morador no banco! {exception}");}
                
                try { AtualizarMoradores(); }
                catch(Exception exception) { MessageBox.Show($"Erro ao obter moradores no banco! {exception}"); }
            }
            else
            {
                MessageBox.Show("Dados incompletos ou senha com menos de 6 caracteres!");
            }
        }

        private void AtualizarMoradores()
        {

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
    }
}
