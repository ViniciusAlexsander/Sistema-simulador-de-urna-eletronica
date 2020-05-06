using System;
using System.Threading;
using System.Windows.Forms;

namespace Urna
{
    public partial class CadastroPartido : Form
    {
        private Thread thread;
        private PartidoDAO partidos;
        public CadastroPartido()
        {
            InitializeComponent();
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Partido part = new Partido()
            {
                Nome = txtNome.Text,
                Numero = txtNumero.Text,
                Sigla = txtSigla.Text,
                VotosTotaisVereador = 0,
                VotosTotaisDepEstadual = 0,
                VotosTotaisDepFederal = 0,
                VagasVereador = 0,
                VagasDepEstudual = 0,
                VagasDepFederal = 0
                
            };

            try
            {
                partidos.Adicionar(part);
                partidos.Salvar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Partido já cadastrado!");
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partidos.MostrarPartidos();
            txtNome.Clear();
            txtNumero.Clear();
            txtSigla.Clear();
            MessageBox.Show("Cadastro realizado!");
        }

        private void CadastroPartido_Load(object sender, EventArgs e)
        {
            partidos = new PartidoDAO();
            partidos.Carregar();
            dataGridView1.DataSource = partidos.MostrarPartidos();


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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
