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
    public partial class FormPainelDeControle : Form
    {
        private FormConfiguracoes formConfiguracoes;
        private FormMorador formMorador;
        private FormVisitante formVisitante;
        private FormAcesso formAcesso;
        public FormPainelDeControle()
        {
            InitializeComponent();
            formConfiguracoes = new FormConfiguracoes(this);
            formMorador = new FormMorador(this);
            formVisitante = new FormVisitante(this);
            formAcesso = new FormAcesso(this);
        }

        private void btConfiguracoes_Click(object sender, EventArgs e)
        {
            if (Condominio.Self != null)
            {
                btConfiguracoes.Enabled = false;
                tsConfiguracoes.Enabled = false;
            }
            else
            {
                this.formConfiguracoes.Show();
                this.Hide();
            }
        }

        private void FormPainelDeControle_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormPainelDeControle_Shown(object sender, EventArgs e)
        {
            
        }

        public void Atualizar()
        {
            if (Condominio.Self != null)
            {
                btConfiguracoes.Enabled = false;
                tsConfiguracoes.Enabled = false;
                btAdicionarMorador.Enabled = true;
                tsMorador.Enabled = true;
                btAtivarMorador.Enabled = true;
                tsVisitante.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                btAdicionarVisitante.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                tsAcesso.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                btVerificacaoAcesso.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
            }
        }

        private void btAdicionarMorador_Click(object sender, EventArgs e)
        {
            formMorador.Show();
            this.Hide();
        }

        private void btAdicionarVisitante_Click(object sender, EventArgs e)
        {
            formVisitante.Show();
            formVisitante.AtualizarDataGridViewMoradores();
            formVisitante.AtualizarListViews();
            this.Hide();
        }

        private void btVerificacaoAcesso_Click(object sender, EventArgs e)
        {
            formAcesso.Show();
            formAcesso.Atualizar();
            this.Hide();
        }
    }
}
