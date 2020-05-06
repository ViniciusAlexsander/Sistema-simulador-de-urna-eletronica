namespace Urna
{
    partial class Votacao
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
            this.btnMunicipal = new System.Windows.Forms.Button();
            this.btnNacional = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMunicipal
            // 
            this.btnMunicipal.Location = new System.Drawing.Point(120, 157);
            this.btnMunicipal.Name = "btnMunicipal";
            this.btnMunicipal.Size = new System.Drawing.Size(239, 83);
            this.btnMunicipal.TabIndex = 0;
            this.btnMunicipal.Text = "Eleição Municipal";
            this.btnMunicipal.UseVisualStyleBackColor = true;
            this.btnMunicipal.Click += new System.EventHandler(this.BtnMunicipal_Click);
            // 
            // btnNacional
            // 
            this.btnNacional.Location = new System.Drawing.Point(455, 157);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(217, 83);
            this.btnNacional.TabIndex = 1;
            this.btnNacional.Text = "Eleição Nacional";
            this.btnNacional.UseVisualStyleBackColor = true;
            this.btnNacional.Click += new System.EventHandler(this.BtnNacional_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(357, 338);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(110, 48);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnNacional);
            this.Controls.Add(this.btnMunicipal);
            this.Name = "Votacao";
            this.Text = "Votacao";
            this.Load += new System.EventHandler(this.Votacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMunicipal;
        private System.Windows.Forms.Button btnNacional;
        private System.Windows.Forms.Button btnMenu;
    }
}