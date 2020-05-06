using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{

    public partial class CadastroCandidato : Form
    {
        private PartidoDAO partidos = new PartidoDAO();
        private CandidatoDAO candidatos;
        private Thread thread;


        public CadastroCandidato()
        {
            InitializeComponent();
        }

        private void BntCadastrar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            string numerop = null;

            partidos.Carregar();
            foreach (Partido p in partidos.MostrarPartidos())
            {
                if (cboPartido.Text == p.Nome)
                {

                    numerop = p.Numero;
                }

            }

            Partido partido = new Partido
            {
                Nome = cboPartido.Text,
                Numero = numerop
            };

            Cargos cargo = new Cargos
            {
                cargo = cboCargo.Text
            };

            Candidato candidato = new Candidato
            {
                Nome = txtNome.Text,
                Partido = partido.Nome,
                Cargo = cargo.cargo,
                Idade = idade,
                Numero = (cboCargo.Text == "Presidente" || cboCargo.Text == "Governador" || cboCargo.Text == "Prefeito") ? partido.Numero + " " : partido.Numero + txtNumero.Text + " ",
                QntVotos = 0

            };

            try
            {
                candidatos.Adicionar(candidato);
                candidatos.Salvar();

            }

            catch (CandidatoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Número de Candidato já cadastrado!");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = candidatos.MostrarCandidato();

        }




        private void CadastroCandidato_Load(object sender, EventArgs e)
        {
            cboCargo.Items.Clear();
            foreach (Cargos c in Cargos.Lista())
            {
                cboCargo.Items.Add(c.cargo);
            }

            cboPartido.Items.Clear();
            partidos.Carregar();
            foreach (Partido c in partidos.MostrarPartidos())
            {
                cboPartido.Items.Add(c.Nome);

            }
            candidatos = new CandidatoDAO();
            candidatos.Carregar();
            dataGridView1.DataSource = candidatos.MostrarCandidato();


        }

        private void BtnMenuCad_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirCadastro);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
        private void abrirCadastro(object obj)
        {
            Application.Run(new Cadastro());
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

        private void BtnNulo_Click(object sender, EventArgs e)
        {
            candidatos.CriarNulo();
            MessageBox.Show("Nulo Criado!");
        }

    }
}
