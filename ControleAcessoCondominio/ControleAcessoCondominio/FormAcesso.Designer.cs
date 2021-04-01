
namespace ControleAcessoCondominio
{
    partial class FormAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAcessoMorador = new System.Windows.Forms.Button();
            this.lbVisitantesMorador = new System.Windows.Forms.Label();
            this.lvVisitantes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvMoradores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAcessoVisitante = new System.Windows.Forms.Button();
            this.lvAcessos = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAcessos = new System.Windows.Forms.Label();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(12, 600);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 0;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAcessoMorador
            // 
            this.btAcessoMorador.Location = new System.Drawing.Point(504, 541);
            this.btAcessoMorador.Name = "btAcessoMorador";
            this.btAcessoMorador.Size = new System.Drawing.Size(160, 53);
            this.btAcessoMorador.TabIndex = 21;
            this.btAcessoMorador.Text = "Verificar Acesso de Morador";
            this.btAcessoMorador.UseVisualStyleBackColor = true;
            this.btAcessoMorador.Click += new System.EventHandler(this.btAcessoMorador_Click);
            // 
            // lbVisitantesMorador
            // 
            this.lbVisitantesMorador.AutoSize = true;
            this.lbVisitantesMorador.Location = new System.Drawing.Point(504, 36);
            this.lbVisitantesMorador.Name = "lbVisitantesMorador";
            this.lbVisitantesMorador.Size = new System.Drawing.Size(111, 13);
            this.lbVisitantesMorador.TabIndex = 20;
            this.lbVisitantesMorador.Text = "Visitantes do morador:";
            // 
            // lvVisitantes
            // 
            this.lvVisitantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvVisitantes.FullRowSelect = true;
            this.lvVisitantes.GridLines = true;
            this.lvVisitantes.HideSelection = false;
            this.lvVisitantes.Location = new System.Drawing.Point(504, 52);
            this.lvVisitantes.Name = "lvVisitantes";
            this.lvVisitantes.Size = new System.Drawing.Size(486, 228);
            this.lvVisitantes.TabIndex = 19;
            this.lvVisitantes.UseCompatibleStateImageBehavior = false;
            this.lvVisitantes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 236;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            this.columnHeader5.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Escolha o morador:";
            // 
            // lvMoradores
            // 
            this.lvMoradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMoradores.FullRowSelect = true;
            this.lvMoradores.GridLines = true;
            this.lvMoradores.HideSelection = false;
            this.lvMoradores.Location = new System.Drawing.Point(12, 52);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(486, 542);
            this.lvMoradores.TabIndex = 17;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
            this.lvMoradores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMoradores_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 236;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ativo";
            // 
            // btAcessoVisitante
            // 
            this.btAcessoVisitante.Location = new System.Drawing.Point(830, 541);
            this.btAcessoVisitante.Name = "btAcessoVisitante";
            this.btAcessoVisitante.Size = new System.Drawing.Size(160, 53);
            this.btAcessoVisitante.TabIndex = 22;
            this.btAcessoVisitante.Text = "Verificar Acesso de Visitante";
            this.btAcessoVisitante.UseVisualStyleBackColor = true;
            this.btAcessoVisitante.Click += new System.EventHandler(this.btAcessoVisitante_Click);
            // 
            // lvAcessos
            // 
            this.lvAcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvAcessos.FullRowSelect = true;
            this.lvAcessos.GridLines = true;
            this.lvAcessos.HideSelection = false;
            this.lvAcessos.Location = new System.Drawing.Point(504, 307);
            this.lvAcessos.Name = "lvAcessos";
            this.lvAcessos.Size = new System.Drawing.Size(486, 228);
            this.lvAcessos.TabIndex = 23;
            this.lvAcessos.UseCompatibleStateImageBehavior = false;
            this.lvAcessos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nome";
            this.columnHeader6.Width = 236;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CPF";
            this.columnHeader7.Width = 149;
            // 
            // lbAcessos
            // 
            this.lbAcessos.AutoSize = true;
            this.lbAcessos.Location = new System.Drawing.Point(504, 291);
            this.lbAcessos.Name = "lbAcessos";
            this.lbAcessos.Size = new System.Drawing.Size(87, 13);
            this.lbAcessos.TabIndex = 24;
            this.lbAcessos.Text = "Últimos Acessos:";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tipo de Acesso";
            this.columnHeader8.Width = 97;
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 635);
            this.Controls.Add(this.lbAcessos);
            this.Controls.Add(this.lvAcessos);
            this.Controls.Add(this.btAcessoVisitante);
            this.Controls.Add(this.btAcessoMorador);
            this.Controls.Add(this.lbVisitantesMorador);
            this.Controls.Add(this.lvVisitantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMoradores);
            this.Controls.Add(this.btVoltar);
            this.Name = "FormAcesso";
            this.Text = "FormAcesso";
            this.Load += new System.EventHandler(this.FormAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAcessoMorador;
        private System.Windows.Forms.Label lbVisitantesMorador;
        private System.Windows.Forms.ListView lvVisitantes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMoradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btAcessoVisitante;
        private System.Windows.Forms.ListView lvAcessos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbAcessos;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}