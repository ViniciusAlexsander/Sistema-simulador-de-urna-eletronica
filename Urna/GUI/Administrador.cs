using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class Administrador : Form
    {
        Thread thread;
        public Administrador()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            /*Realiza um login com uma senha, caso a senha esteja correta
            o usuário é redirecionado a tela de cadastro*/

            if (txtSenha.Text == "123")
            {
                this.Close();
                thread = new Thread(abrirCadastro);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Senha Incorreta!");
            }
        }
        //Método para abrir a outra tela
        private void abrirCadastro(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirMenu(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
