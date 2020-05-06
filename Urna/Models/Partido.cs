using System.Collections.Generic;

namespace Urna
{
    public class Partido
    {
        private string nome;
        private string sigla;
        private string numero;
        private List<Candidato> vereadores = new List<Candidato>();
        private List<Candidato> depFederal = new List<Candidato>();
        private List<Candidato> depEstadual = new List<Candidato>();
        PartidoDAO partidos = new PartidoDAO();
        private int votosTotaisVereador;
        private int votosTotaisDepFederal;
        private int votosTotaisDepEstadual;
        private int vagasVereador;
        private int vagasDepFederal;
        private int vagasDepEstudual;

        //private List<Candidato> candidatos;

        //public List<Candidato> getCandidatos()
        //{
        //    return candidatos;
        //}

        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Numero { get => numero; set => numero = value; }
        //public List<Candidato> Vereadores { get => vereadores; set => vereadores = value; }
        //public List<Candidato> DepFederal { get => depFederal; set => depFederal = value; }
        //public List<Candidato> DepEstadual { get => depEstadual; set => depEstadual = value; }
        public int VotosTotaisVereador { get => votosTotaisVereador; set => votosTotaisVereador = value; }
        public int VotosTotaisDepFederal { get => votosTotaisDepFederal; set => votosTotaisDepFederal = value; }
        public int VotosTotaisDepEstadual { get => votosTotaisDepEstadual; set => votosTotaisDepEstadual = value; }
        public int VagasVereador { get => vagasVereador; set => vagasVereador = value; }
        public int VagasDepFederal { get => vagasDepFederal; set => vagasDepFederal = value; }
        public int VagasDepEstudual { get => vagasDepEstudual; set => vagasDepEstudual = value; }

        public int VotosVereador(List<Candidato> candidatos)
        {
            foreach(Candidato candidato in candidatos)
            {
                if (candidato.Cargo == "Vereador" && candidato.Partido == Nome)
                    VotosTotaisVereador = VotosTotaisVereador + candidato.QntVotos;
            }
            return VotosTotaisVereador;
        }
    }
}

