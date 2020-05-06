using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class ConfiguracaoEleicaoMuni : Form
    {
        private Thread thread;
        private CandidatoDAO candidatos = new CandidatoDAO();
        private  EleicaoM eleicao = new EleicaoM();
        private static bool segundoTurno = false;
        private PartidoDAO partidos = new PartidoDAO();
        private string strPathFile = @"ResultadoMunicipal.txt";
        private int vagasDisponiveisVereador=0;

        //Metodos de acesso
        public static bool SegundoTurno { get => segundoTurno; set => segundoTurno = value; }
        internal EleicaoM Eleicao { get => eleicao; set => eleicao = value; }
        public int VagasDisponiveisVereador { get => vagasDisponiveisVereador; set => vagasDisponiveisVereador = value; }

        public ConfiguracaoEleicaoMuni()
        {
            InitializeComponent();
        }


        private void btnEncerrar_Click(object sender, EventArgs e)
        {

            if (VagasDisponiveisVereador > 0)
            {
                EleicaoMunicipal municipal = new EleicaoMunicipal();
                int eleitores = municipal.Eleitores;
                candidatos.Carregar();
                partidos.Carregar();

                foreach (Candidato c in candidatos.MostrarCandidato())
                {
                    if(c.Partido !="Nulo")
                    {
                        if (c.Cargo == "Prefeito")
                        {
                            eleitores += c.QntVotos;
                        }

                    }                    
                }

                try
                {
                    Eleicao.calculaResultadoVereador(candidatos.MostrarCandidato(),VagasDisponiveisVereador,partidos.MostrarPartidos());
                    partidos.Salvar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                PartidoDAO partido = new PartidoDAO();
                Eleicao.CalculoResultado();
                if (Eleicao.PrimeiroPref.QntVotos < (eleitores / 2))
                {
                    MessageBox.Show("Segundo Turno!");
                    this.Close();
                    thread = new Thread(abrirMunicipal);
                    thread.SetApartmentState(ApartmentState.STA);
                    SegundoTurno = true;
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Prefeito: \n1ºLugar - " + Eleicao.PrimeiroPref.Nome);
                    SegundoTurno = false;
                }
                for (int i = 0; i < partido.MostrarPartidos().Count; i++)
                {
                    MessageBox.Show($"Partido: {partido.MostrarPartidos()[i]}");
                }
            }
            else
            {
                MessageBox.Show("Digite a quantidade de vagas disponíveis para vereadores antes de encerrar");
            }

            CriarRelatorio();
            Concatenar();

        }
        private void abrirMunicipal(object obj)
        {
            Application.Run(new EleicaoMunicipal());
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            VagasDisponiveisVereador = Convert.ToInt32(txtCadeiras.Text);
            MessageBox.Show("Número de cadeiras recebido");

        }

        private void CriarRelatorio()
        {
            try
            {
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Primeiro Turno:");
                        sw.WriteLine("Prefeitos:\n");
                        foreach (Candidato c in candidatos.MostrarCandidato())
                        {
                            if (c.Cargo == "Prefeito")
                            {
                                if (c.Partido != "Nulo")
                                {
                                    sw.WriteLine(c.Cargo + " - " + c.Nome + " - " + "  " + c.Partido + "- Quantidade de votos:" + c.QntVotos);
                                    
                                }
                                else
                                {

                                    sw.WriteLine($"Votos Nulos:{c.QntVotos}");
                                }
                            }

                        }

                        sw.WriteLine($"Votos brancos: {EleicaoM.VotosPrefBrancos}");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void Concatenar()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        sw.WriteLine("Vereadores");
                        foreach (Candidato c in candidatos.MostrarCandidato())
                        {
                            if (c.Cargo == "Vereador")

                            {
                                if (c.Partido != "Nulo")
                                {
                                    sw.WriteLine(c.Cargo + " - " + c.Nome + " - " + "  " + c.Partido + "- Quantidade de votos:" + c.QntVotos);

                                }
                                else
                                {

                                    sw.WriteLine($"Votos Nulos:{c.QntVotos}");
                                }
                            }


                        }
                        sw.WriteLine("Quantidades de vagas por partido:\n");
                        partidos.Carregar();

                        foreach (Partido p in partidos.MostrarPartidos())
                        {
                            sw.WriteLine(p.Nome + ": " + p.VagasVereador);
                        }
                        sw.WriteLine($"Número de eleitores: {Eleicao.Eleitores}");
                       sw.WriteLine($"Número de votos brancos: {EleicaoM.VotosVerBrancos}");

                    }
                    MessageBox.Show("Arquivo Atualizado!");
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            abrirRelatorio();
        }
        private void abrirRelatorio()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    System.Diagnostics.Process.Start(strPathFile);
                }
                else
                {
                    MessageBox.Show("Eleicão não finalizada!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
