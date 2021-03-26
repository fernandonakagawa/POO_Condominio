
namespace ControleAcessoCondominio
{
    partial class FormVisitante
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
            this.lvMoradores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvVisitantes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbVisitantesMorador = new System.Windows.Forms.Label();
            this.btAdicionarVisitante = new System.Windows.Forms.Button();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lvMoradores.Location = new System.Drawing.Point(12, 46);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(486, 228);
            this.lvMoradores.TabIndex = 8;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
            this.lvMoradores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMoradores_ItemSelectionChanged);
            this.lvMoradores.SelectedIndexChanged += new System.EventHandler(this.lvMoradores_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escolha o morador anfitrião:";
            // 
            // lvVisitantes
            // 
            this.lvVisitantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvVisitantes.FullRowSelect = true;
            this.lvVisitantes.GridLines = true;
            this.lvVisitantes.HideSelection = false;
            this.lvVisitantes.Location = new System.Drawing.Point(12, 309);
            this.lvVisitantes.Name = "lvVisitantes";
            this.lvVisitantes.Size = new System.Drawing.Size(486, 228);
            this.lvVisitantes.TabIndex = 10;
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
            // lbVisitantesMorador
            // 
            this.lbVisitantesMorador.AutoSize = true;
            this.lbVisitantesMorador.Location = new System.Drawing.Point(12, 293);
            this.lbVisitantesMorador.Name = "lbVisitantesMorador";
            this.lbVisitantesMorador.Size = new System.Drawing.Size(111, 13);
            this.lbVisitantesMorador.TabIndex = 11;
            this.lbVisitantesMorador.Text = "Visitantes do morador:";
            // 
            // btAdicionarVisitante
            // 
            this.btAdicionarVisitante.Enabled = false;
            this.btAdicionarVisitante.Location = new System.Drawing.Point(373, 574);
            this.btAdicionarVisitante.Name = "btAdicionarVisitante";
            this.btAdicionarVisitante.Size = new System.Drawing.Size(128, 27);
            this.btAdicionarVisitante.TabIndex = 16;
            this.btAdicionarVisitante.Text = "Adicionar Visitante";
            this.btAdicionarVisitante.UseVisualStyleBackColor = true;
            this.btAdicionarVisitante.Click += new System.EventHandler(this.btAdicionarVisitante_Click);
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(62, 581);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(273, 20);
            this.tbCpf.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "CPF:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(62, 546);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(273, 20);
            this.tbNome.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(12, 617);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(128, 27);
            this.btVoltar.TabIndex = 17;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 656);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAdicionarVisitante);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbVisitantesMorador);
            this.Controls.Add(this.lvVisitantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMoradores);
            this.Name = "FormVisitante";
            this.Text = "FormVisitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMoradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvVisitantes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbVisitantesMorador;
        private System.Windows.Forms.Button btAdicionarVisitante;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoltar;
    }
}