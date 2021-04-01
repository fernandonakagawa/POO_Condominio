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
    public partial class FormAcesso : Form
    {
        FormPainelDeControle formPainelDeControle;
        public FormAcesso(FormPainelDeControle formPainelDeControle)
        {
            InitializeComponent();
            this.formPainelDeControle = formPainelDeControle;
        }

        public void Atualizar()
        {
            lvMoradores.Items.Clear();
            lvVisitantes.Items.Clear();
            lvAcessos.Items.Clear();
            foreach (Morador m in Condominio.Self.Moradores)
            {
                ListViewItem item = new ListViewItem(m.Nome);
                item.SubItems.Add(m.Cpf);
                if (m.IsAtivo) item.SubItems.Add("Sim");
                else item.SubItems.Add("Não");
                lvMoradores.Items.Add(item);
            }
            foreach(Acesso a in Condominio.Self.Acessos)
            {
                ListViewItem item = new ListViewItem(a.Pessoa.Nome);
                item.SubItems.Add(a.Pessoa.Cpf);
                item.SubItems.Add(a.TipoAcesso.ToString());
                lvAcessos.Items.Add(item);
            }
            lbAcessos.Text = $"Últimos acessos: (número de acessos: {Acesso.NumeroAcessos})";
        }
        private void FormAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPainelDeControle.Show();
            this.Hide();
        }

        private void lvMoradores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {

                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    lbVisitantesMorador.Text = $"Visitantes do morador {m.Nome}";
                    lvVisitantes.Items.Clear();
                    foreach (Visitante v in Condominio.Self.Visitantes)
                    {
                        foreach (Morador x in v.Anfitrioes)
                        {
                            if (x == m)
                            {
                                ListViewItem itemVisitante = new ListViewItem(v.Nome);
                                itemVisitante.SubItems.Add(v.Cpf);
                                lvVisitantes.Items.Add(itemVisitante);
                                //lvMoradores.SelectedItems.Clear();
                            }
                        }
                    }
                }
            }
        }

        private void btAcessoMorador_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    TipoAcesso tipoAcesso = Condominio.Self.VerificarAcesso(m);
                    switch (tipoAcesso)
                    {
                        case TipoAcesso.Permitido:
                            MessageBox.Show("Acesso permitido!");
                            break;
                        case TipoAcesso.Negado:
                            MessageBox.Show("Acesso NEGADO!");
                            break;
                        case TipoAcesso.Desativado:
                            MessageBox.Show("Acesso NEGADO! Morador Desativado!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao verificar acesso! Morador não encontrado!");
                }
                //lvMoradores.SelectedItems.Clear();
                lvVisitantes.SelectedItems.Clear();
                Atualizar();
            }
            else
            {
                MessageBox.Show("Selecione um morador!");
            }
        }

        private void btAcessoVisitante_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0 &&
                lvVisitantes.SelectedItems.Count > 0)
            {
                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null)
                {
                    ListViewItem itemVisitante = lvVisitantes.SelectedItems[0];
                    string cpfVisitante = itemVisitante.SubItems[1].Text;
                    Visitante v = Condominio.Self.BuscarVisitante(cpfVisitante);
                    if(v != null)
                    {
                        TipoAcesso tipoAcesso = 
                            Condominio.Self.VerificarAcesso(v, m);
                        switch (tipoAcesso)
                        {
                            case TipoAcesso.Permitido:
                                MessageBox.Show("Acesso permitido!");
                                break;
                            case TipoAcesso.Negado:
                                MessageBox.Show("Acesso NEGADO!");
                                break;
                            case TipoAcesso.Desativado:
                                MessageBox.Show("Acesso NEGADO! Morador Desativado!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao verificar acesso! Visitante não encontrado!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Erro ao verificar acesso! Morador não encontrado!");
                }
                //lvMoradores.SelectedItems.Clear();
                lvVisitantes.SelectedItems.Clear();
                Atualizar();
            }
            else
            {
                MessageBox.Show("Selecione um morador e um visitante!");
            }
        }
    }
}
