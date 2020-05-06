namespace Urna
{
    partial class Cadastro
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
            this.btnPartido = new System.Windows.Forms.Button();
            this.btnCandidato = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnMunicipal = new System.Windows.Forms.Button();
            this.btnConfigFederal = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnPartido
            // 
            this.btnPartido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPartido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartido.Location = new System.Drawing.Point(27, 111);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(200, 64);
            this.btnPartido.TabIndex = 1;
            this.btnPartido.Text = "Partido";
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.BtnPartido_Click);
            // 
            // btnCandidato
            // 
            this.btnCandidato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCandidato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidato.Location = new System.Drawing.Point(308, 111);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Size = new System.Drawing.Size(200, 64);
            this.btnCandidato.TabIndex = 2;
            this.btnCandidato.Text = "Candidato";
            this.btnCandidato.UseVisualStyleBackColor = true;
            this.btnCandidato.Click += new System.EventHandler(this.BtnCandidato_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(308, 313);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 64);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir todos os cadastros";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnMunicipal
            // 
            this.btnMunicipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMunicipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMunicipal.Location = new System.Drawing.Point(27, 217);
            this.btnMunicipal.Name = "btnMunicipal";
            this.btnMunicipal.Size = new System.Drawing.Size(200, 64);
            this.btnMunicipal.TabIndex = 4;
            this.btnMunicipal.Text = "Configurar Eleição Municipal";
            this.btnMunicipal.UseVisualStyleBackColor = true;
            this.btnMunicipal.Click += new System.EventHandler(this.BtnMunicipal_Click);
            // 
            // btnConfigFederal
            // 
            this.btnConfigFederal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfigFederal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigFederal.Location = new System.Drawing.Point(308, 217);
            this.btnConfigFederal.Name = "btnConfigFederal";
            this.btnConfigFederal.Size = new System.Drawing.Size(200, 64);
            this.btnConfigFederal.TabIndex = 5;
            this.btnConfigFederal.Text = "Configurar Eleição Federal";
            this.btnConfigFederal.UseVisualStyleBackColor = true;
            this.btnConfigFederal.Click += new System.EventHandler(this.btnConfigFederal_Click_1);
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuInicial.Location = new System.Drawing.Point(27, 354);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(91, 23);
            this.btnMenuInicial.TabIndex = 7;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 50);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Painel Administrativo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnConfigFederal);
            this.Controls.Add(this.btnMunicipal);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCandidato);
            this.Controls.Add(this.btnPartido);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Administrativo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.Button btnCandidato;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnMunicipal;
        private System.Windows.Forms.Button btnConfigFederal;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}