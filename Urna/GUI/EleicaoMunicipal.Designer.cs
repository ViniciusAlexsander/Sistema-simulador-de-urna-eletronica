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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleição Municipal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prefeito";
            // 
            // cboPrefeito
            // 
            this.cboPrefeito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrefeito.FormattingEnabled = true;
            this.cboPrefeito.Location = new System.Drawing.Point(191, 172);
            this.cboPrefeito.Name = "cboPrefeito";
            this.cboPrefeito.Size = new System.Drawing.Size(202, 25);
            this.cboPrefeito.TabIndex = 2;
            // 
            // lbVereador
            // 
            this.lbVereador.AutoSize = true;
            this.lbVereador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVereador.Location = new System.Drawing.Point(125, 213);
            this.lbVereador.Name = "lbVereador";
            this.lbVereador.Size = new System.Drawing.Size(62, 17);
            this.lbVereador.TabIndex = 3;
            this.lbVereador.Text = "Vereador";
            // 
            // cboVereador
            // 
            this.cboVereador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVereador.FormattingEnabled = true;
            this.cboVereador.Location = new System.Drawing.Point(191, 210);
            this.cboVereador.Name = "cboVereador";
            this.cboVereador.Size = new System.Drawing.Size(202, 25);
            this.cboVereador.TabIndex = 4;
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(292, 285);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(117, 42);
            this.btnVotar.TabIndex = 5;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(129, 285);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(117, 42);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 49);
            this.panel1.TabIndex = 7;
            // 
            // EleicaoMunicipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.cboVereador);
            this.Controls.Add(this.lbVereador);
            this.Controls.Add(this.cboPrefeito);
            this.Controls.Add(this.label2);
            this.Name = "EleicaoMunicipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EleicaoMunicipal";
            this.Load += new System.EventHandler(this.EleicaoMunicipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}