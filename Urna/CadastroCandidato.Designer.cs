namespace Urna
{
    partial class CadastroCandidato
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPartido = new System.Windows.Forms.ComboBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.btnMenuCad = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnNulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 20);
            this.txtNome.TabIndex = 0;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(25, 66);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 13);
            this.l.TabIndex = 1;
            this.l.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro de Candidato";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Partido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número:";
            // 
            // cboPartido
            // 
            this.cboPartido.FormattingEnabled = true;
            this.cboPartido.Location = new System.Drawing.Point(69, 124);
            this.cboPartido.Name = "cboPartido";
            this.cboPartido.Size = new System.Drawing.Size(157, 21);
            this.cboPartido.TabIndex = 9;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(69, 151);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(157, 21);
            this.cboCargo.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(69, 179);
            this.txtNumero.Mask = "000000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(84, 218);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bntCadastrar.TabIndex = 12;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.BntCadastrar_Click);
            // 
            // btnMenuCad
            // 
            this.btnMenuCad.Location = new System.Drawing.Point(250, 229);
            this.btnMenuCad.Name = "btnMenuCad";
            this.btnMenuCad.Size = new System.Drawing.Size(127, 23);
            this.btnMenuCad.TabIndex = 13;
            this.btnMenuCad.Text = "Painel Administrativo";
            this.btnMenuCad.UseVisualStyleBackColor = true;
            this.btnMenuCad.Click += new System.EventHandler(this.BtnMenuCad_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(395, 229);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(127, 23);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(69, 93);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(48, 20);
            this.txtIdade.TabIndex = 15;
            // 
            // btnNulo
            // 
            this.btnNulo.Location = new System.Drawing.Point(84, 247);
            this.btnNulo.Name = "btnNulo";
            this.btnNulo.Size = new System.Drawing.Size(75, 23);
            this.btnNulo.TabIndex = 16;
            this.btnNulo.Text = "Criar Nulo";
            this.btnNulo.UseVisualStyleBackColor = true;
            this.btnNulo.Click += new System.EventHandler(this.BtnNulo_Click);
            // 
            // CadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 311);
            this.Controls.Add(this.btnNulo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnMenuCad);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.cboPartido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroCandidato";
            this.Text = "Cadastro de Candidato";
            this.Load += new System.EventHandler(this.CadastroCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPartido;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Button btnMenuCad;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnNulo;
    }
}