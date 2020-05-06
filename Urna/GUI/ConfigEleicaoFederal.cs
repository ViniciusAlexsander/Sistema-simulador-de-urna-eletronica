using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class ConfigEleicaoFederal : Form
    {
        private Thread thread;
        private CandidatoDAO candidatos = new CandidatoDAO();
        private static bool segundoTPres = false;
        private static bool segundoTGov = false;
        private static EleicaoF eleicao = new EleicaoF();

        public static bool SegundoTPres { get => segundoTPres; set => segundoTPres = value; }
        public static bool SegundoTGov { get => segundoTGov; set => segundoTGov = value; }
        internal static EleicaoF Eleicao { get => eleicao; set => eleicao = value; }

        public ConfigEleicaoFederal()
        {
            InitializeComponent();
        }

        private void btnEncerrarFederal_Click(object sender, EventArgs e)
        {
            if (Eleicao.VagasDisponiveisDepEstadual > 0 && Eleicao.VagasDisponiveisDepFederal > 0)
            {
                EleicaoNacional federal = new EleicaoNacional();
                EleicaoF eleicao = new EleicaoF();
                candidatos.Carregar();
                double eleitores = 0;
                foreach (Candidato c in candidatos.MostrarCandidato())
                {
                    if (c.Cargo == "Presidente")
                    {
                        eleitores += c.QntVotos;
                    }
                }
                eleicao.CalculoResultado();
                MessageBox.Show(eleitores.ToString());
                if (eleicao.PrimeiroGov.QntVotos < (eleitores / 2))
                {
                    MessageBox.Show("Segundo Turno de Governadores!");
                    this.Close();
                    SegundoTGov = true;
                    if (SegundoTPres == false)
                    {
                        thread = new Thread(abrirFederal);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }


                }
                else
                {
                    MessageBox.Show("Presidente: \n1ºLugar - " + eleicao.PrimeiroPres.Nome);
                }

                if (eleicao.PrimeiroPres.QntVotos < (eleitores / 2))
                {
                    MessageBox.Show("Segundo Turno de Presidentes!");
                    this.Close();
                    SegundoTPres = true;
                    thread = new Thread(abrirFederal);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                }
                else
                {
                    MessageBox.Show("Presidente: \n1ºLugar - " + eleicao.PrimeiroPres.Nome);
                }
            }
            else
            {
                MessageBox.Show("Digite a quantidade de vagas disponíveis para Deputados Estaduais e Federais antes de encerrar");
            }

        }
        private void abrirFederal(object obj)
        {
            Application.Run(new EleicaoNacional());
        }


        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirMenuInicial);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirMenuInicial(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnEnviaCadeiras_Click(object sender, EventArgs e)
        {
            Eleicao.VagasDisponiveisDepEstadual = Convert.ToInt32(maskedTxtCadeirasDepEstadual.Text);
            Eleicao.VagasDisponiveisDepFederal = Convert.ToInt32(maskedTxtCadeirasDepFederal.Text);
            MessageBox.Show("Número de cadeiras recebido");
        }

    }
}
