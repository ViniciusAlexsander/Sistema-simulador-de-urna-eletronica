using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMunicipal_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirAdministrador);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAdministrador(object obj)
        {
            Application.Run(new Administrador());
        }

        private void BtnVotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirVotacao);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void abrirVotacao(object obj)
        {
            Application.Run(new Votacao());
        }
    }
}
