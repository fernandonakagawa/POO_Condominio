
namespace ControleAcessoCondominio
{
    partial class FormPainelDeControle
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDoCondomínioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMoradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarDesativarMoradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVisitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.verificaçãoDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btVerificacaoAcesso = new System.Windows.Forms.Button();
            this.btConfiguracoes = new System.Windows.Forms.Button();
            this.btAtivarMorador = new System.Windows.Forms.Button();
            this.btAdicionarMorador = new System.Windows.Forms.Button();
            this.btAdicionarVisitante = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfiguracoes,
            this.tsMorador,
            this.tsVisitante,
            this.tsAcesso});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Configurações";
            // 
            // tsConfiguracoes
            // 
            this.tsConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesDoCondomínioToolStripMenuItem});
            this.tsConfiguracoes.Name = "tsConfiguracoes";
            this.tsConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsConfiguracoes.Text = "Configurações";
            // 
            // configuraçõesDoCondomínioToolStripMenuItem
            // 
            this.configuraçõesDoCondomínioToolStripMenuItem.Name = "configuraçõesDoCondomínioToolStripMenuItem";
            this.configuraçõesDoCondomínioToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.configuraçõesDoCondomínioToolStripMenuItem.Text = "Configurações do Condomínio";
            this.configuraçõesDoCondomínioToolStripMenuItem.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // tsMorador
            // 
            this.tsMorador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMoradorToolStripMenuItem,
            this.ativarDesativarMoradorToolStripMenuItem});
            this.tsMorador.Enabled = false;
            this.tsMorador.Name = "tsMorador";
            this.tsMorador.Size = new System.Drawing.Size(65, 20);
            this.tsMorador.Text = "Morador";
            // 
            // adicionarMoradorToolStripMenuItem
            // 
            this.adicionarMoradorToolStripMenuItem.Name = "adicionarMoradorToolStripMenuItem";
            this.adicionarMoradorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.adicionarMoradorToolStripMenuItem.Text = "Adicionar Morador";
            this.adicionarMoradorToolStripMenuItem.Click += new System.EventHandler(this.btAdicionarMorador_Click);
            // 
            // ativarDesativarMoradorToolStripMenuItem
            // 
            this.ativarDesativarMoradorToolStripMenuItem.Name = "ativarDesativarMoradorToolStripMenuItem";
            this.ativarDesativarMoradorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ativarDesativarMoradorToolStripMenuItem.Text = "Ativar/Desativar Morador";
            this.ativarDesativarMoradorToolStripMenuItem.Click += new System.EventHandler(this.btAdicionarMorador_Click);
            // 
            // tsVisitante
            // 
            this.tsVisitante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVisitanteToolStripMenuItem});
            this.tsVisitante.Enabled = false;
            this.tsVisitante.Name = "tsVisitante";
            this.tsVisitante.Size = new System.Drawing.Size(64, 20);
            this.tsVisitante.Text = "Visitante";
            // 
            // adicionarVisitanteToolStripMenuItem
            // 
            this.adicionarVisitanteToolStripMenuItem.Name = "adicionarVisitanteToolStripMenuItem";
            this.adicionarVisitanteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.adicionarVisitanteToolStripMenuItem.Text = "Adicionar Visitante";
            // 
            // tsAcesso
            // 
            this.tsAcesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificaçãoDeAcessoToolStripMenuItem});
            this.tsAcesso.Enabled = false;
            this.tsAcesso.Name = "tsAcesso";
            this.tsAcesso.Size = new System.Drawing.Size(56, 20);
            this.tsAcesso.Text = "Acesso";
            // 
            // verificaçãoDeAcessoToolStripMenuItem
            // 
            this.verificaçãoDeAcessoToolStripMenuItem.Name = "verificaçãoDeAcessoToolStripMenuItem";
            this.verificaçãoDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verificaçãoDeAcessoToolStripMenuItem.Text = "Verificação de Acesso";
            // 
            // btVerificacaoAcesso
            // 
            this.btVerificacaoAcesso.Enabled = false;
            this.btVerificacaoAcesso.Location = new System.Drawing.Point(12, 280);
            this.btVerificacaoAcesso.Name = "btVerificacaoAcesso";
            this.btVerificacaoAcesso.Size = new System.Drawing.Size(336, 158);
            this.btVerificacaoAcesso.TabIndex = 1;
            this.btVerificacaoAcesso.Text = "Verificação de Acesso";
            this.btVerificacaoAcesso.UseVisualStyleBackColor = true;
            // 
            // btConfiguracoes
            // 
            this.btConfiguracoes.Location = new System.Drawing.Point(12, 72);
            this.btConfiguracoes.Name = "btConfiguracoes";
            this.btConfiguracoes.Size = new System.Drawing.Size(336, 46);
            this.btConfiguracoes.TabIndex = 2;
            this.btConfiguracoes.Text = "Configurações";
            this.btConfiguracoes.UseVisualStyleBackColor = true;
            this.btConfiguracoes.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // btAtivarMorador
            // 
            this.btAtivarMorador.Enabled = false;
            this.btAtivarMorador.Location = new System.Drawing.Point(12, 176);
            this.btAtivarMorador.Name = "btAtivarMorador";
            this.btAtivarMorador.Size = new System.Drawing.Size(336, 46);
            this.btAtivarMorador.TabIndex = 3;
            this.btAtivarMorador.Text = "Ativar ou Desativar Morador";
            this.btAtivarMorador.UseVisualStyleBackColor = true;
            this.btAtivarMorador.Click += new System.EventHandler(this.btAdicionarMorador_Click);
            // 
            // btAdicionarMorador
            // 
            this.btAdicionarMorador.Enabled = false;
            this.btAdicionarMorador.Location = new System.Drawing.Point(12, 124);
            this.btAdicionarMorador.Name = "btAdicionarMorador";
            this.btAdicionarMorador.Size = new System.Drawing.Size(336, 46);
            this.btAdicionarMorador.TabIndex = 4;
            this.btAdicionarMorador.Text = "Adicionar Morador";
            this.btAdicionarMorador.UseVisualStyleBackColor = true;
            this.btAdicionarMorador.Click += new System.EventHandler(this.btAdicionarMorador_Click);
            // 
            // btAdicionarVisitante
            // 
            this.btAdicionarVisitante.Enabled = false;
            this.btAdicionarVisitante.Location = new System.Drawing.Point(12, 228);
            this.btAdicionarVisitante.Name = "btAdicionarVisitante";
            this.btAdicionarVisitante.Size = new System.Drawing.Size(336, 46);
            this.btAdicionarVisitante.TabIndex = 5;
            this.btAdicionarVisitante.Text = "Adicionar Visitante";
            this.btAdicionarVisitante.UseVisualStyleBackColor = true;
            // 
            // FormPainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.btAdicionarVisitante);
            this.Controls.Add(this.btAdicionarMorador);
            this.Controls.Add(this.btAtivarMorador);
            this.Controls.Add(this.btConfiguracoes);
            this.Controls.Add(this.btVerificacaoAcesso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPainelDeControle";
            this.Text = "Painel de Controle";
            this.Load += new System.EventHandler(this.FormPainelDeControle_Shown);
            this.Shown += new System.EventHandler(this.FormPainelDeControle_Shown);
            this.Enter += new System.EventHandler(this.FormPainelDeControle_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDoCondomínioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMorador;
        private System.Windows.Forms.ToolStripMenuItem adicionarMoradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativarDesativarMoradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsVisitante;
        private System.Windows.Forms.ToolStripMenuItem adicionarVisitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAcesso;
        private System.Windows.Forms.ToolStripMenuItem verificaçãoDeAcessoToolStripMenuItem;
        private System.Windows.Forms.Button btVerificacaoAcesso;
        private System.Windows.Forms.Button btConfiguracoes;
        private System.Windows.Forms.Button btAtivarMorador;
        private System.Windows.Forms.Button btAdicionarMorador;
        private System.Windows.Forms.Button btAdicionarVisitante;
    }
}

