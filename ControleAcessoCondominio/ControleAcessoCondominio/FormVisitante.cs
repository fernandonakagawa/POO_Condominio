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
    public partial class FormVisitante : Form
    {
        private FormPainelDeControle formPainelDeControle;
        public FormVisitante(FormPainelDeControle formPainelDeControle)
        {
            InitializeComponent();
            this.formPainelDeControle = formPainelDeControle;
        }

        public void Atualizar()
        {
            lvMoradores.Items.Clear();
            lvVisitantes.Items.Clear();
            foreach(Morador m in Condominio.Self.Moradores)
            {
                ListViewItem item = new ListViewItem(m.Nome);
                item.SubItems.Add(m.Cpf);
                if (m.IsAtivo) item.SubItems.Add("Sim");
                else item.SubItems.Add("Não");
                lvMoradores.Items.Add(item);
            }
        }

        private void btAdicionarVisitante_Click(object sender, EventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                ListViewItem itemMorador = lvMoradores.SelectedItems[0];
                string cpf = itemMorador.SubItems[1].Text;
                Morador m = Condominio.Self.BuscarMorador(cpf);
                if (m != null && tbNome.Text.Length > 0 && tbCpf.Text.Length > 0)
                {
                    string nomeVisitante = tbNome.Text;
                    string cpfVisitante = tbCpf.Text;
                    Visitante v = new Visitante(nomeVisitante, cpfVisitante, m);
                    Condominio.Self.AdicionarVisitante(v);
                    ListViewItem itemVisitante = new ListViewItem(nomeVisitante);
                    itemVisitante.SubItems.Add(cpfVisitante);
                    lvVisitantes.Items.Add(itemVisitante);
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar visitante!");
                }
                tbNome.Text = "";
                tbCpf.Text = "";
                //btAdicionarVisitante.Enabled = false;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPainelDeControle.Show();
            formPainelDeControle.Atualizar();
            this.Hide();
        }

        private void lvMoradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lvMoradores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvMoradores.SelectedItems.Count > 0)
            {
                btAdicionarVisitante.Enabled = true;

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
                                lvMoradores.SelectedItems.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}
