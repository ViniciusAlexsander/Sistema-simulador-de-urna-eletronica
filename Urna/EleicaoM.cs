using System;
using System.Collections.Generic;
using System.Linq;

namespace Urna
{
    class EleicaoM : IExecutivo
    {
        private CandidatoDAO candidatos = new CandidatoDAO();
        private int eleitores;
        private Candidato primeiroPref = new Candidato();
        private Candidato segundoPref = new Candidato();
        //private int vagasDisponiveisVereador;
        //private Partido partido;
        private PartidoDAO partidoDAO = new PartidoDAO();

        public int Eleitores { get => eleitores; set => eleitores = value; }
        public Candidato PrimeiroPref { get => primeiroPref; set => primeiroPref = value; }
        public Candidato SegundoPref { get => segundoPref; set => segundoPref = value; }
        //public int VagasDisponiveisVereador { get => vagasDisponiveisVereador; set => vagasDisponiveisVereador = value; }
        //public Partido Partido { get => partido; set => partido = value; }

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
                partidos[j].VagasVereador = partidos[j].VotosTotaisVereador / qeEleitoral;
                qePartido = partidos[j].VotosTotaisVereador / qeEleitoral;
                partidoDAO.AlterarVereador(partidos[j], (int)qePartido);
                partidoDAO.Salvar();
                vagasDisponiveisVereador -= partidos[j].VagasVereador;
            }

            while (vagasDisponiveisVereador > 0)
            {
                //verifica qual partido que tem a maior média
                for (int ind = 0;ind < partidos.Count; ind++)
                {
                    if(partidos[ind].VotosTotaisVereador / (partidos[ind].VagasVereador + 1) > partidos[ind].VotosTotaisVereador / (partidos[ind + 1].VagasVereador + 1))
                    {
                        nomeMaiorPartido = partidoDAO.MostrarPartidos()[ind].Nome;
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
                vagasDisponiveisVereador -= 1;
            }
            
        }
        
    }
}

