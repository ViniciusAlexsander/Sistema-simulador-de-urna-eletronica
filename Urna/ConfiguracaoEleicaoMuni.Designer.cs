namespace Urna
{
    partial class ConfiguracaoEleicaoMuni
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
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.txtCadeiras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(233, 196);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(145, 23);
            this.btnEncerrar.TabIndex = 0;
            this.btnEncerrar.Text = "Encerrar Eleição Municipal";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // txtCadeiras
            // 
            this.txtCadeiras.Location = new System.Drawing.Point(375, 98);
            this.txtCadeiras.Name = "txtCadeiras";
            this.txtCadeiras.Size = new System.Drawing.Size(39, 20);
            this.txtCadeiras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o número de cadeiras disponíveis para os Vereadores:";
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(384, 196);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(145, 23);
            this.btnMenuInicial.TabIndex = 3;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(82, 196);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(145, 23);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Text = "Painel Administrativo";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(420, 95);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(233, 225);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(145, 23);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Abrir Relatório Final";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // ConfiguracaoEleicaoMuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 254);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadeiras);
            this.Controls.Add(this.btnEncerrar);
            this.Name = "ConfiguracaoEleicaoMuni";
            this.Text = "Configuração Eleição Municipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.TextBox txtCadeiras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRelatorio;
    }
}