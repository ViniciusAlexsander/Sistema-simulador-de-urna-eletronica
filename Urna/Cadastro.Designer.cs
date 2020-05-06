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
            this.btnPartido.Location = new System.Drawing.Point(58, 44);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(200, 64);
            this.btnPartido.TabIndex = 1;
            this.btnPartido.Text = "Partido";
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.BtnPartido_Click);
            // 
            // btnCandidato
            // 
            this.btnCandidato.Location = new System.Drawing.Point(559, 44);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Size = new System.Drawing.Size(200, 64);
            this.btnCandidato.TabIndex = 2;
            this.btnCandidato.Text = "Candidato";
            this.btnCandidato.UseVisualStyleBackColor = true;
            this.btnCandidato.Click += new System.EventHandler(this.BtnCandidato_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(320, 44);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 64);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir todos os cadastros";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnMunicipal
            // 
            this.btnMunicipal.Location = new System.Drawing.Point(182, 187);
            this.btnMunicipal.Name = "btnMunicipal";
            this.btnMunicipal.Size = new System.Drawing.Size(200, 64);
            this.btnMunicipal.TabIndex = 4;
            this.btnMunicipal.Text = "Configurar Eleição Municipal";
            this.btnMunicipal.UseVisualStyleBackColor = true;
            this.btnMunicipal.Click += new System.EventHandler(this.BtnMunicipal_Click);
            // 
            // btnConfigFederal
            // 
            this.btnConfigFederal.Location = new System.Drawing.Point(433, 187);
            this.btnConfigFederal.Name = "btnConfigFederal";
            this.btnConfigFederal.Size = new System.Drawing.Size(200, 64);
            this.btnConfigFederal.TabIndex = 5;
            this.btnConfigFederal.Text = "Configurar Eleição Federal";
            this.btnConfigFederal.UseVisualStyleBackColor = true;
            this.btnConfigFederal.Click += new System.EventHandler(this.btnConfigFederal_Click_1);
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(361, 312);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(91, 23);
            this.btnMenuInicial.TabIndex = 7;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnConfigFederal);
            this.Controls.Add(this.btnMunicipal);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCandidato);
            this.Controls.Add(this.btnPartido);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Painel Administrativo";
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
    }
}