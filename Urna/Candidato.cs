namespace Urna
{

    public class Candidato
    {
        private string nome;
        private int idade;
        private int qntVotos;
        private string partido;
        private string numero;
        private string cargo;

        public string Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Partido { get => partido; set => partido = value; }


        public int QntVotos { get => qntVotos; set => qntVotos = value; }





    }
}
