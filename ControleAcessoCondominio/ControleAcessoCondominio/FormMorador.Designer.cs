
namespace ControleAcessoCondominio
{
    partial class FormMorador
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdicionarMorador = new System.Windows.Forms.Button();
            this.lvMoradores = new System.Windows.Forms.ListView();
            this.btAtivarMorador = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btMudarSenha = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(67, 63);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(273, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(67, 98);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(273, 20);
            this.tbCpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(67, 135);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(273, 20);
            this.tbSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // btAdicionarMorador
            // 
            this.btAdicionarMorador.Location = new System.Drawing.Point(384, 128);
            this.btAdicionarMorador.Name = "btAdicionarMorador";
            this.btAdicionarMorador.Size = new System.Drawing.Size(128, 27);
            this.btAdicionarMorador.TabIndex = 6;
            this.btAdicionarMorador.Text = "Adicionar Morador";
            this.btAdicionarMorador.UseVisualStyleBackColor = true;
            this.btAdicionarMorador.Click += new System.EventHandler(this.btAdicionarMorador_Click);
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
            this.lvMoradores.Location = new System.Drawing.Point(26, 178);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(486, 228);
            this.lvMoradores.TabIndex = 7;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
            // 
            // btAtivarMorador
            // 
            this.btAtivarMorador.Location = new System.Drawing.Point(384, 415);
            this.btAtivarMorador.Name = "btAtivarMorador";
            this.btAtivarMorador.Size = new System.Drawing.Size(128, 23);
            this.btAtivarMorador.TabIndex = 8;
            this.btAtivarMorador.Text = "Ativar/Desativar Morador";
            this.btAtivarMorador.UseVisualStyleBackColor = true;
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
            // btMudarSenha
            // 
            this.btMudarSenha.Location = new System.Drawing.Point(250, 415);
            this.btMudarSenha.Name = "btMudarSenha";
            this.btMudarSenha.Size = new System.Drawing.Size(128, 23);
            this.btMudarSenha.TabIndex = 9;
            this.btMudarSenha.Text = "Mudar Senha";
            this.btMudarSenha.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(26, 415);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(128, 23);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ativo";
            // 
            // FormMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btMudarSenha);
            this.Controls.Add(this.btAtivarMorador);
            this.Controls.Add(this.lvMoradores);
            this.Controls.Add(this.btAdicionarMorador);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "FormMorador";
            this.Text = "Moradores";
            this.Load += new System.EventHandler(this.FormMorador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdicionarMorador;
        private System.Windows.Forms.ListView lvMoradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btAtivarMorador;
        private System.Windows.Forms.Button btMudarSenha;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}