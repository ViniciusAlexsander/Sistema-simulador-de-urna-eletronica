using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class Votacao : Form
    {
        private Thread thread;
        public Votacao()
        {
            InitializeComponent();
        }

        private void BtnMunicipal_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirMunicipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void abrirMunicipal(object obj)
        {
            Application.Run(new EleicaoMunicipal());
        }

        private void BtnNacional_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirNacional);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void abrirNacional(object obj)
        {
            Application.Run(new EleicaoNacional());
        }

        private void Votacao_Load(object sender, EventArgs e)
        {

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
