namespace Urna
{
    partial class EleicaoMunicipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboPrefeito = new System.Windows.Forms.ComboBox();
            this.lbVereador = new System.Windows.Forms.Label();
            this.cboVereador = new System.Windows.Forms.ComboBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleição Municipal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prefeito";
            // 
            // cboPrefeito
            // 
            this.cboPrefeito.FormattingEnabled = true;
            this.cboPrefeito.Location = new System.Drawing.Point(73, 67);
            this.cboPrefeito.Name = "cboPrefeito";
            this.cboPrefeito.Size = new System.Drawing.Size(202, 21);
            this.cboPrefeito.TabIndex = 2;
            // 
            // lbVereador
            // 
            this.lbVereador.AutoSize = true;
            this.lbVereador.Location = new System.Drawing.Point(17, 108);
            this.lbVereador.Name = "lbVereador";
            this.lbVereador.Size = new System.Drawing.Size(50, 13);
            this.lbVereador.TabIndex = 3;
            this.lbVereador.Text = "Vereador";
            // 
            // cboVereador
            // 
            this.cboVereador.FormattingEnabled = true;
            this.cboVereador.Location = new System.Drawing.Point(73, 105);
            this.cboVereador.Name = "cboVereador";
            this.cboVereador.Size = new System.Drawing.Size(202, 21);
            this.cboVereador.TabIndex = 4;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(124, 132);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 5;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 170);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // EleicaoMunicipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 205);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.cboVereador);
            this.Controls.Add(this.lbVereador);
            this.Controls.Add(this.cboPrefeito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EleicaoMunicipal";
            this.Text = "EleicaoMunicipal";
            this.Load += new System.EventHandler(this.EleicaoMunicipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPrefeito;
        private System.Windows.Forms.Label lbVereador;
        private System.Windows.Forms.ComboBox cboVereador;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnMenu;
    }
}