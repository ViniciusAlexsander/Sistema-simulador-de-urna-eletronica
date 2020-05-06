using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Urna
{
    class EleicaoM : IExecutivo
    {
        private CandidatoDAO candidatos = new CandidatoDAO();
        private int eleitores;
        private Candidato primeiroPref = new Candidato();
        private Candidato segundoPref = new Candidato();
        private PartidoDAO partidoDAO = new PartidoDAO();
        private Partido partido = new Partido();
        private static int votosPrefBrancos;
        private static int votosVerBrancos;

        public int Eleitores { get => eleitores; set => eleitores = value; }
        public Candidato PrimeiroPref { get => primeiroPref; set => primeiroPref = value; }
        public Candidato SegundoPref { get => segundoPref; set => segundoPref = value; }
        public static int VotosPrefBrancos { get => votosPrefBrancos; set => votosPrefBrancos = value; }
        public static int VotosVerBrancos { get => votosVerBrancos; set => votosVerBrancos = value; }

        public void CalculoResultado()
        {
            List<Candidato> prefeitos = new List<Candidato>();
            candidatos.Carregar();

            for (int i = 0; i < candidatos.MostrarCandidato().Count; i++)
            {
                if (candidatos.MostrarCandidato()[i].Cargo == "Prefeito")
                {
                    prefeitos.Add(candidatos.MostrarCandidato()[i]);


                }
            }

            for (int i = 0; i < prefeitos.Count - 2; i++)
            {
                if (prefeitos[i + 1].QntVotos > prefeitos[i].QntVotos)
                {
                    PrimeiroPref = prefeitos[i + 1];
                    SegundoPref = prefeitos[i];
                }
                else
                {
                    PrimeiroPref = prefeitos[i];
                    SegundoPref = prefeitos[i + 1];
                }

            }




        }
        public void calculaResultadoVereador(List<Candidato> candidatos, int vagasDisponiveisVereador,List<Partido> partidos)
        {
            string nomeMaiorPartido = "Partidão";
            int eleitores = 0, qeEleitoral, vagasPreenchidas = 0;
            double qePartido;
            for (int i = 0; i < candidatos.Count; i++)
            {
                if (candidatos[i].Cargo == "Vereador")
                {
                    eleitores = eleitores + candidatos[i].QntVotos;
                }
            }

            qeEleitoral = eleitores / vagasDisponiveisVereador;
            for(int j = 0;j < partidos.Count;j++)
            {
                partidos[j].VagasVereador = partidos[j].VotosVereador(candidatos) / qeEleitoral;
                qePartido = partidos[j].VotosTotaisVereador / qeEleitoral;
                partidoDAO.AlterarVereador(partidos[j], (int)qePartido);
                partidoDAO.Salvar();
                vagasPreenchidas += partidos[j].VagasVereador;
            }

            while (vagasDisponiveisVereador > vagasPreenchidas)
            {
                //verifica qual partido que tem a maior média
                for (int ind = 0;ind < partidos.Count-2; ind++)
                {
                    int testeVotos1, votos2, vagas1, vagas2;
                    testeVotos1 = partidos[ind].VotosTotaisVereador;
                    votos2 = partidos[ind + 1].VotosTotaisVereador;
                    vagas1 = partidos[ind].VagasVereador;
                    vagas2 = partidos[ind + 1].VagasVereador;
                    if ((partidos[ind].VotosTotaisVereador / (partidos[ind].VagasVereador + 1)) > (partidos[ind+1].VotosTotaisVereador / (partidos[ind + 1].VagasVereador + 1)))
                    {
                        nomeMaiorPartido = partidos[ind].Nome;
                    }

                }
                //Esse for é usado para atribuir +1 vaga para o partido que tiver a maior media
                foreach (Partido partido in partidos)
                {
                    if (nomeMaiorPartido == partido.Nome)
                    {
                        partidoDAO.AlterarVereador(partido, partido.VagasVereador + 1);

                    }
                }
                vagasPreenchidas += 1;
            }
            
        }



    }
}

