using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class EleicaoNacional : Form
    {
        private CandidatoDAO candidato = new CandidatoDAO();
        private Thread thread;
        private int eleitores = 0;

        public int Eleitores { get => eleitores; set => eleitores = value; }

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
        public EleicaoNacional()
        {
            InitializeComponent();
        }

        private void BtnVotar_Click(object sender, EventArgs e)
        {
            playSimpleSound();

            foreach (Candidato c in candidato.MostrarCandidato())
            {
                if (cboPresidente.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }
                if (cboDeputadoF.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }
                if (cboDeputadoE.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }
                if (cboGovernador.Text == c.Numero + c.Nome)
                {
                    candidato.Alterar(c, c.QntVotos + 1);
                }

            }
            MessageBox.Show("FIM");
            cboPresidente.SelectedIndex = -1;
            cboGovernador.SelectedIndex = -1;
            cboDeputadoE.SelectedIndex = -1;
            cboDeputadoF.SelectedIndex = -1;
            candidato.Salvar();

        }

        private void EleicaoNacional_Load(object sender, EventArgs e)
        {
            candidato.Carregar();
            if (Cadastro.SegundoTGov == false && Cadastro.SegundoTPres == false)
            {
                foreach (Candidato c in candidato.MostrarCandidato())
                {
                    if (c.Cargo == "Presidente")
                    {
                        cboPresidente.Items.Add(c.Numero + c.Nome);
                    }
                    else
                    if (c.Cargo == "Governador")
                    {
                        cboGovernador.Items.Add(c.Numero + c.Nome);
                    }
                    else
                    if (c.Cargo == "Deputado Estadual")
                    {
                        cboDeputadoE.Items.Add(c.Numero + c.Nome);
                    }
                    else
                    if (c.Cargo == "Deputado Federal")
                    {
                        cboDeputadoF.Items.Add(c.Numero + c.Nome);
                    }
                }
            }
            else
            {

                {
                    candidato.Alterar(Cadastro.EleicaoF.SegundoPres, 0);
                    candidato.Alterar(Cadastro.EleicaoF.PrimeiroPres, 0);
                    candidato.Alterar(Cadastro.EleicaoF.SegundoGov, 0);
                    candidato.Alterar(Cadastro.EleicaoF.PrimeiroGov, 0);
                    candidato.Salvar();
                    cboDeputadoE.Hide();
                    cboDeputadoF.Hide();
                    if (Cadastro.SegundoTGov == false)
                    {
                        cboGovernador.Hide();
                    }


                    if (Cadastro.SegundoTPres == false)
                    {
                        cboPresidente.Hide();
                    }
                    cboPresidente.Items.Add(Cadastro.EleicaoF.PrimeiroPres.Numero + Cadastro.EleicaoF.PrimeiroPres.Nome);
                    cboPresidente.Items.Add(Cadastro.EleicaoF.SegundoPres.Numero + Cadastro.EleicaoF.SegundoPres.Nome);
                    cboGovernador.Items.Add(Cadastro.EleicaoF.PrimeiroGov.Numero + Cadastro.EleicaoF.PrimeiroGov.Nome);
                    cboGovernador.Items.Add(Cadastro.EleicaoF.SegundoGov.Numero + Cadastro.EleicaoF.SegundoGov.Nome);


                }


            }


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
