using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class Cadastro : Form
    {
        private Thread thread;
        private CandidatoDAO candidatos = new CandidatoDAO();
        private static bool segundoTurno = false;
        private static bool segundoTPres = false;
        private static bool segundoTGov = false;
        private static EleicaoM eleicao = new EleicaoM();
        private static EleicaoF eleicaoF = new EleicaoF();
        public static bool SegundoTurno { get => segundoTurno; set => segundoTurno = value; }
        internal static EleicaoM Eleicao { get => eleicao; set => eleicao = value; }
        public static bool SegundoTPres { get => segundoTPres; set => segundoTPres = value; }
        public static bool SegundoTGov { get => segundoTGov; set => segundoTGov = value; }
        internal static EleicaoF EleicaoF { get => eleicaoF; set => eleicaoF = value; }

        public Cadastro()
        {
            InitializeComponent();
        }

        private void BtnPartido_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirPartido);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void abrirPartido(object obj)
        {
            Application.Run(new CadastroPartido());
        }

        private void BtnCandidato_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirCandidato);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirCandidato(object obj)
        {
            Application.Run(new CadastroCandidato());
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            candidatos.ResetEleicao();
            MessageBox.Show("Cadastros Excluídos!");

        }
        private void BtnMunicipal_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirConfigEleicaoMuni);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirConfigEleicaoMuni(object obj)
        {
            Application.Run(new ConfiguracaoEleicaoMuni());
        }
        //private void BtnMunicipal_Click(object sender, EventArgs e)
        //{
        //    EleicaoMunicipal municipal = new EleicaoMunicipal();
        //    int eleitores = municipal.Eleitores;
        //    candidatos.Carregar();

        //    foreach (Candidato c in candidatos.MostrarCandidato())
        //    {
        //        if (c.Cargo == "Prefeito")
        //        {
        //            eleitores += c.QntVotos;
        //        }
        //    }

        //    Eleicao.CalculoResultado();
        //    if (Eleicao.PrimeiroPref.QntVotos < (eleitores / 2))
        //    {
        //        MessageBox.Show("Segundo Turno!");
        //        this.Close();
        //        thread = new Thread(abrirMunicipal);
        //        thread.SetApartmentState(ApartmentState.STA);
        //        SegundoTurno = true;
        //        thread.Start();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Prefeito: \n1ºLugar - " + Eleicao.PrimeiroPref.Nome);
        //        SegundoTurno = false;
        //    }

        //}
        private void abrirMunicipal(object obj)
        {
            Application.Run(new EleicaoMunicipal());
        }
        private void abrirConfigFederal(object obj)
        {
            Application.Run(new ConfigEleicaoFederal());
        }
        //private void BtnConfigFederal_Click(object sender, EventArgs e)
        //{
        //    EleicaoNacional federal = new EleicaoNacional();
        //    EleicaoF eleicao = new EleicaoF();
        //    candidatos.Carregar();
        //    double eleitores = 0;
        //    foreach (Candidato c in candidatos.MostrarCandidato())
        //    {
        //        if (c.Cargo == "Presidente")
        //        {
        //            eleitores += c.QntVotos;
        //        }
        //    }
        //    eleicao.CalculoResultado();
        //    MessageBox.Show(eleitores.ToString());
        //    if (eleicao.PrimeiroGov.QntVotos < (eleitores / 2))
        //    {
        //        MessageBox.Show("Segundo Turno de Governadores!");
        //        this.Close();
        //        SegundoTGov = true;
        //        if (SegundoTPres == false)
        //        {
        //            thread = new Thread(abrirFederal);
        //            thread.SetApartmentState(ApartmentState.STA);
        //            thread.Start();
        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Presidente: \n1ºLugar - " + eleicao.PrimeiroPres.Nome);
        //    }

        //    if (eleicao.PrimeiroPres.QntVotos < (eleitores / 2))
        //    {
        //        MessageBox.Show("Segundo Turno de Presidentes!");
        //        this.Close();
        //        SegundoTPres = true;
        //        thread = new Thread(abrirFederal);
        //        thread.SetApartmentState(ApartmentState.STA);
        //        thread.Start();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Presidente: \n1ºLugar - " + eleicao.PrimeiroPres.Nome);
        //    }

        //}
        private void abrirFederal(object obj)
        {
            Application.Run(new EleicaoNacional());
        }


        private void btnConfigFederal_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirConfigFederal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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
    }
}
