namespace Urna
{
    partial class ConfigEleicaoFederal
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
            this.btnEncerrarFederal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnEnviaCadeiras = new System.Windows.Forms.Button();
            this.maskedTxtCadeirasDepEstadual = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtCadeirasDepFederal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnEncerrarFederal
            // 
            this.btnEncerrarFederal.Location = new System.Drawing.Point(233, 331);
            this.btnEncerrarFederal.Name = "btnEncerrarFederal";
            this.btnEncerrarFederal.Size = new System.Drawing.Size(141, 23);
            this.btnEncerrarFederal.TabIndex = 0;
            this.btnEncerrarFederal.Text = "Encerrar Eleição Federal";
            this.btnEncerrarFederal.UseVisualStyleBackColor = true;
            this.btnEncerrarFederal.Click += new System.EventHandler(this.btnEncerrarFederal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o número de cadeiras disponíveis para os Deputados Estaduais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o número de cadeiras disponíveis para os Deputados Federais:";
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(42, 331);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(141, 23);
            this.btnMenuPrincipal.TabIndex = 5;
            this.btnMenuPrincipal.Text = "Painel Administrativo";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(300, 244);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(141, 23);
            this.btnMenuInicial.TabIndex = 6;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // btnEnviaCadeiras
            // 
            this.btnEnviaCadeiras.Location = new System.Drawing.Point(390, 183);
            this.btnEnviaCadeiras.Name = "btnEnviaCadeiras";
            this.btnEnviaCadeiras.Size = new System.Drawing.Size(75, 23);
            this.btnEnviaCadeiras.TabIndex = 7;
            this.btnEnviaCadeiras.Text = "Enviar";
            this.btnEnviaCadeiras.UseVisualStyleBackColor = true;
            this.btnEnviaCadeiras.Click += new System.EventHandler(this.btnEnviaCadeiras_Click);
            // 
            // maskedTxtCadeirasDepEstadual
            // 
            this.maskedTxtCadeirasDepEstadual.Location = new System.Drawing.Point(419, 109);
            this.maskedTxtCadeirasDepEstadual.Mask = "00";
            this.maskedTxtCadeirasDepEstadual.Name = "maskedTxtCadeirasDepEstadual";
            this.maskedTxtCadeirasDepEstadual.Size = new System.Drawing.Size(41, 20);
            this.maskedTxtCadeirasDepEstadual.TabIndex = 8;
            // 
            // maskedTxtCadeirasDepFederal
            // 
            this.maskedTxtCadeirasDepFederal.Location = new System.Drawing.Point(419, 144);
            this.maskedTxtCadeirasDepFederal.Mask = "00";
            this.maskedTxtCadeirasDepFederal.Name = "maskedTxtCadeirasDepFederal";
            this.maskedTxtCadeirasDepFederal.Size = new System.Drawing.Size(41, 20);
            this.maskedTxtCadeirasDepFederal.TabIndex = 9;
            // 
            // ConfigEleicaoFederal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 406);
            this.Controls.Add(this.maskedTxtCadeirasDepFederal);
            this.Controls.Add(this.maskedTxtCadeirasDepEstadual);
            this.Controls.Add(this.btnEnviaCadeiras);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncerrarFederal);
            this.Name = "ConfigEleicaoFederal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigEleicaoFederal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncerrarFederal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnEnviaCadeiras;
        private System.Windows.Forms.MaskedTextBox maskedTxtCadeirasDepEstadual;
        private System.Windows.Forms.MaskedTextBox maskedTxtCadeirasDepFederal;
    }
}