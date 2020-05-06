namespace Urna
{
    partial class EleicaoNacional
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
            this.btnVotar = new System.Windows.Forms.Button();
            this.cboDeputadoF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDeputadoE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPresidente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGovernador = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleição Nacional";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(160, 211);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
            // 
            // cboDeputadoF
            // 
            this.cboDeputadoF.FormattingEnabled = true;
            this.cboDeputadoF.Location = new System.Drawing.Point(130, 73);
            this.cboDeputadoF.Name = "cboDeputadoF";
            this.cboDeputadoF.Size = new System.Drawing.Size(158, 21);
            this.cboDeputadoF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deputado Federal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deputado Estadual";
            // 
            // cboDeputadoE
            // 
            this.cboDeputadoE.FormattingEnabled = true;
            this.cboDeputadoE.Location = new System.Drawing.Point(131, 101);
            this.cboDeputadoE.Name = "cboDeputadoE";
            this.cboDeputadoE.Size = new System.Drawing.Size(157, 21);
            this.cboDeputadoE.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Presidente";
            // 
            // cboPresidente
            // 
            this.cboPresidente.FormattingEnabled = true;
            this.cboPresidente.Location = new System.Drawing.Point(131, 129);
            this.cboPresidente.Name = "cboPresidente";
            this.cboPresidente.Size = new System.Drawing.Size(157, 21);
            this.cboPresidente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Governador";
            // 
            // cboGovernador
            // 
            this.cboGovernador.FormattingEnabled = true;
            this.cboGovernador.Location = new System.Drawing.Point(132, 162);
            this.cboGovernador.Name = "cboGovernador";
            this.cboGovernador.Size = new System.Drawing.Size(156, 21);
            this.cboGovernador.TabIndex = 9;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 232);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // EleicaoNacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 267);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cboGovernador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPresidente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDeputadoE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDeputadoF);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.label1);
            this.Name = "EleicaoNacional";
            this.Text = "EleicaoNacional";
            this.Load += new System.EventHandler(this.EleicaoNacional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ComboBox cboDeputadoF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDeputadoE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPresidente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGovernador;
        private System.Windows.Forms.Button btnMenu;
    }
}