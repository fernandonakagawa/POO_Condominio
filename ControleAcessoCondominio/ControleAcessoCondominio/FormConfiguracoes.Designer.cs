﻿
namespace ControleAcessoCondominio
{
    partial class FormConfiguracoes
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
            this.tbNomeCondominio = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Condomínio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNomeCondominio
            // 
            this.tbNomeCondominio.Location = new System.Drawing.Point(131, 61);
            this.tbNomeCondominio.Name = "tbNomeCondominio";
            this.tbNomeCondominio.Size = new System.Drawing.Size(250, 20);
            this.tbNomeCondominio.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(92, 131);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(209, 50);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 211);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbNomeCondominio);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracoes";
            this.Text = "FormConfiguracoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeCondominio;
        private System.Windows.Forms.Button btOk;
    }
}