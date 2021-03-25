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
    public partial class FormConfiguracoes : Form
    {
        private FormPainelDeControle _formAnterior;
        public FormConfiguracoes(FormPainelDeControle formAnterior)
        {
            InitializeComponent();
            this._formAnterior = formAnterior;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string nomeCondominio = tbNomeCondominio.Text;
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja criar o condomínio? " +
                "Não será possível modificar o nome depois!", "Confirmação",
                MessageBoxButtons.YesNo);
            if(resposta == DialogResult.Yes)
            {
                tbNomeCondominio.Enabled = false;
                Condominio c = new Condominio(nomeCondominio);
                Condominio.Self = c;
                this._formAnterior.Show();
                this._formAnterior.Atualizar();
                this.Hide();
            }
            else
            {
                this._formAnterior.Show();
                this.Hide();
            }
            
        }
    }
}
