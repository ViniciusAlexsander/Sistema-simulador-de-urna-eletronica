using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class EleicaoMunicipal : Form
    {
        private CandidatoDAO candidato = new CandidatoDAO();
        private Thread thread;
        private int eleitores = 0;
        public int Eleitores { get => eleitores; set => eleitores = value; }

        public EleicaoMunicipal()
        {
            InitializeComponent();
        }
        private void playSimpleSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Urna.wav");
                simpleSound.Play();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void EleicaoMunicipal_Load(object sender, EventArgs e)
        {
            candidato.Carregar();

            if (Cadastro.SegundoTurno == false)
                foreach (Candidato c in candidato.MostrarCandidato())
                {
                    if (c.Cargo == "Vereador")
                    {
                        cboVereador.Items.Add(c.Numero + c.Nome);
                    }
                    else
                    if (c.Cargo == "Prefeito")
                    {
                        cboPrefeito.Items.Add(c.Numero + c.Nome);
                    }


                }
            else
            {
                cboVereador.Hide();
                lbVereador.Hide(); 
                candidato.Alterar(Cadastro.Eleicao.SegundoPref, 0);
                candidato.Alterar(Cadastro.Eleicao.PrimeiroPref, 0);
                candidato.Salvar();
                cboPrefeito.Items.Add(Cadastro.Eleicao.PrimeiroPref.Numero + Cadastro.Eleicao.PrimeiroPref.Nome);
                cboPrefeito.Items.Add(Cadastro.Eleicao.SegundoPref.Numero + Cadastro.Eleicao.SegundoPref.Nome);
            }


        }
        private void BtnVotar_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            foreach (Candidato c in candidato.MostrarCandidato())
            {
                if (cboPrefeito.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }
                if (cboVereador.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }


            }
            candidato.Salvar();
            MessageBox.Show("FIM");
            cboPrefeito.SelectedIndex = -1;
            cboVereador.SelectedIndex = -1;
            Eleitores = Eleitores + 1;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
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
