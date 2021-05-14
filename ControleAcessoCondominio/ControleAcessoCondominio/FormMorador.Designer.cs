﻿
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAtivarMorador = new System.Windows.Forms.Button();
            this.btMudarSenha = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.btOkNovaSenha = new System.Windows.Forms.Button();
            this.dgvMoradores = new System.Windows.Forms.DataGridView();
            this.gbBuscaMorador = new System.Windows.Forms.GroupBox();
            this.btBuscarMoradorNome = new System.Windows.Forms.Button();
            this.tbBuscaNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBusca = new System.Windows.Forms.Label();
            this.btMudarSenhaDgv = new System.Windows.Forms.Button();
            this.btAtivarMoradorDgv = new System.Windows.Forms.Button();
            this.btOkNovaSenhaDgv = new System.Windows.Forms.Button();
            this.tbNovaSenhaDgv = new System.Windows.Forms.TextBox();
            this.lbNovaSenhaDgv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).BeginInit();
            this.gbBuscaMorador.SuspendLayout();
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
            this.lvMoradores.Location = new System.Drawing.Point(26, 204);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(486, 202);
            this.lvMoradores.TabIndex = 7;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
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
            // btAtivarMorador
            // 
            this.btAtivarMorador.Enabled = false;
            this.btAtivarMorador.Location = new System.Drawing.Point(384, 415);
            this.btAtivarMorador.Name = "btAtivarMorador";
            this.btAtivarMorador.Size = new System.Drawing.Size(128, 23);
            this.btAtivarMorador.TabIndex = 8;
            this.btAtivarMorador.Text = "Ativar/Desativar Morador";
            this.btAtivarMorador.UseVisualStyleBackColor = true;
            this.btAtivarMorador.Click += new System.EventHandler(this.btAtivarMorador_Click);
            // 
            // btMudarSenha
            // 
            this.btMudarSenha.Enabled = false;
            this.btMudarSenha.Location = new System.Drawing.Point(250, 415);
            this.btMudarSenha.Name = "btMudarSenha";
            this.btMudarSenha.Size = new System.Drawing.Size(128, 23);
            this.btMudarSenha.TabIndex = 9;
            this.btMudarSenha.Text = "Mudar Senha";
            this.btMudarSenha.UseVisualStyleBackColor = true;
            this.btMudarSenha.Click += new System.EventHandler(this.btMudarSenha_Click);
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
            // tbNovaSenha
            // 
            this.tbNovaSenha.Location = new System.Drawing.Point(99, 460);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.PasswordChar = '*';
            this.tbNovaSenha.Size = new System.Drawing.Size(273, 20);
            this.tbNovaSenha.TabIndex = 12;
            this.tbNovaSenha.Visible = false;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Location = new System.Drawing.Point(23, 463);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(70, 13);
            this.lbNovaSenha.TabIndex = 11;
            this.lbNovaSenha.Text = "Nova Senha:";
            this.lbNovaSenha.Visible = false;
            this.lbNovaSenha.Click += new System.EventHandler(this.label4_Click);
            // 
            // btOkNovaSenha
            // 
            this.btOkNovaSenha.Location = new System.Drawing.Point(384, 458);
            this.btOkNovaSenha.Name = "btOkNovaSenha";
            this.btOkNovaSenha.Size = new System.Drawing.Size(128, 23);
            this.btOkNovaSenha.TabIndex = 13;
            this.btOkNovaSenha.Text = "OK";
            this.btOkNovaSenha.UseVisualStyleBackColor = true;
            this.btOkNovaSenha.Visible = false;
            this.btOkNovaSenha.Click += new System.EventHandler(this.btOkNovaSenha_Click);
            // 
            // dgvMoradores
            // 
            this.dgvMoradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoradores.Location = new System.Drawing.Point(519, 204);
            this.dgvMoradores.Name = "dgvMoradores";
            this.dgvMoradores.Size = new System.Drawing.Size(491, 202);
            this.dgvMoradores.TabIndex = 14;
            this.dgvMoradores.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMoradores_CellBeginEdit);
            this.dgvMoradores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoradores_CellContentClick);
            this.dgvMoradores.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvMoradores_RowStateChanged);
            this.dgvMoradores.SelectionChanged += new System.EventHandler(this.dgvMoradores_SelectionChanged);
            // 
            // gbBuscaMorador
            // 
            this.gbBuscaMorador.Controls.Add(this.btBuscarMoradorNome);
            this.gbBuscaMorador.Controls.Add(this.tbBuscaNome);
            this.gbBuscaMorador.Controls.Add(this.label4);
            this.gbBuscaMorador.Location = new System.Drawing.Point(519, 63);
            this.gbBuscaMorador.Name = "gbBuscaMorador";
            this.gbBuscaMorador.Size = new System.Drawing.Size(491, 100);
            this.gbBuscaMorador.TabIndex = 15;
            this.gbBuscaMorador.TabStop = false;
            this.gbBuscaMorador.Text = "Buscar Morador";
            // 
            // btBuscarMoradorNome
            // 
            this.btBuscarMoradorNome.Location = new System.Drawing.Point(50, 65);
            this.btBuscarMoradorNome.Name = "btBuscarMoradorNome";
            this.btBuscarMoradorNome.Size = new System.Drawing.Size(159, 27);
            this.btBuscarMoradorNome.TabIndex = 16;
            this.btBuscarMoradorNome.Text = "Buscar morador por nome";
            this.btBuscarMoradorNome.UseVisualStyleBackColor = true;
            this.btBuscarMoradorNome.Click += new System.EventHandler(this.btBuscarMoradorNome_Click);
            // 
            // tbBuscaNome
            // 
            this.tbBuscaNome.Location = new System.Drawing.Point(50, 32);
            this.tbBuscaNome.Name = "tbBuscaNome";
            this.tbBuscaNome.Size = new System.Drawing.Size(273, 20);
            this.tbBuscaNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Location = new System.Drawing.Point(29, 178);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(114, 13);
            this.lbBusca.TabIndex = 16;
            this.lbBusca.Text = "TODOS os moradores:";
            // 
            // btMudarSenhaDgv
            // 
            this.btMudarSenhaDgv.Enabled = false;
            this.btMudarSenhaDgv.Location = new System.Drawing.Point(749, 415);
            this.btMudarSenhaDgv.Name = "btMudarSenhaDgv";
            this.btMudarSenhaDgv.Size = new System.Drawing.Size(128, 23);
            this.btMudarSenhaDgv.TabIndex = 18;
            this.btMudarSenhaDgv.Text = "Mudar Senha";
            this.btMudarSenhaDgv.UseVisualStyleBackColor = true;
            this.btMudarSenhaDgv.Click += new System.EventHandler(this.btMudarSenhaDgv_Click);
            // 
            // btAtivarMoradorDgv
            // 
            this.btAtivarMoradorDgv.Enabled = false;
            this.btAtivarMoradorDgv.Location = new System.Drawing.Point(883, 415);
            this.btAtivarMoradorDgv.Name = "btAtivarMoradorDgv";
            this.btAtivarMoradorDgv.Size = new System.Drawing.Size(128, 23);
            this.btAtivarMoradorDgv.TabIndex = 17;
            this.btAtivarMoradorDgv.Text = "Ativar/Desativar Morador";
            this.btAtivarMoradorDgv.UseVisualStyleBackColor = true;
            this.btAtivarMoradorDgv.Visible = false;
            // 
            // btOkNovaSenhaDgv
            // 
            this.btOkNovaSenhaDgv.Location = new System.Drawing.Point(889, 458);
            this.btOkNovaSenhaDgv.Name = "btOkNovaSenhaDgv";
            this.btOkNovaSenhaDgv.Size = new System.Drawing.Size(128, 23);
            this.btOkNovaSenhaDgv.TabIndex = 21;
            this.btOkNovaSenhaDgv.Text = "OK";
            this.btOkNovaSenhaDgv.UseVisualStyleBackColor = true;
            this.btOkNovaSenhaDgv.Visible = false;
            this.btOkNovaSenhaDgv.Click += new System.EventHandler(this.btOkNovaSenhaDgv_Click);
            // 
            // tbNovaSenhaDgv
            // 
            this.tbNovaSenhaDgv.Location = new System.Drawing.Point(604, 460);
            this.tbNovaSenhaDgv.Name = "tbNovaSenhaDgv";
            this.tbNovaSenhaDgv.PasswordChar = '*';
            this.tbNovaSenhaDgv.Size = new System.Drawing.Size(273, 20);
            this.tbNovaSenhaDgv.TabIndex = 20;
            this.tbNovaSenhaDgv.Visible = false;
            // 
            // lbNovaSenhaDgv
            // 
            this.lbNovaSenhaDgv.AutoSize = true;
            this.lbNovaSenhaDgv.Location = new System.Drawing.Point(528, 463);
            this.lbNovaSenhaDgv.Name = "lbNovaSenhaDgv";
            this.lbNovaSenhaDgv.Size = new System.Drawing.Size(70, 13);
            this.lbNovaSenhaDgv.TabIndex = 19;
            this.lbNovaSenhaDgv.Text = "Nova Senha:";
            this.lbNovaSenhaDgv.Visible = false;
            // 
            // FormMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 492);
            this.Controls.Add(this.btOkNovaSenhaDgv);
            this.Controls.Add(this.tbNovaSenhaDgv);
            this.Controls.Add(this.lbNovaSenhaDgv);
            this.Controls.Add(this.btMudarSenhaDgv);
            this.Controls.Add(this.btAtivarMoradorDgv);
            this.Controls.Add(this.lbBusca);
            this.Controls.Add(this.gbBuscaMorador);
            this.Controls.Add(this.dgvMoradores);
            this.Controls.Add(this.btOkNovaSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.lbNovaSenha);
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
            this.Shown += new System.EventHandler(this.FormMorador_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormMorador_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).EndInit();
            this.gbBuscaMorador.ResumeLayout(false);
            this.gbBuscaMorador.PerformLayout();
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
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.Button btOkNovaSenha;
        private System.Windows.Forms.DataGridView dgvMoradores;
        private System.Windows.Forms.GroupBox gbBuscaMorador;
        private System.Windows.Forms.Button btBuscarMoradorNome;
        private System.Windows.Forms.TextBox tbBuscaNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.Button btMudarSenhaDgv;
        private System.Windows.Forms.Button btAtivarMoradorDgv;
        private System.Windows.Forms.Button btOkNovaSenhaDgv;
        private System.Windows.Forms.TextBox tbNovaSenhaDgv;
        private System.Windows.Forms.Label lbNovaSenhaDgv;
    }
}