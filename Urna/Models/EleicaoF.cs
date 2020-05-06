using System.Collections.Generic;

namespace Urna
{
    class EleicaoF : IExecutivo
    {
        private CandidatoDAO candidatos = new CandidatoDAO();
        private int eleitores;
        private Candidato primeiroPres = new Candidato();
        private Candidato segundoPres = new Candidato();
        private Candidato primeiroGov = new Candidato();
        private Candidato segundoGov = new Candidato();
        private int vagasDisponiveisDepFederal;
        private int vagasDisponiveisDepEstadual;

        public int Eleitores { get => eleitores; set => eleitores = value; }
        public Candidato PrimeiroPres { get => primeiroPres; set => primeiroPres = value; }
        public Candidato SegundoPres { get => segundoPres; set => segundoPres = value; }
        public Candidato PrimeiroGov { get => primeiroGov; set => primeiroGov = value; }
        public Candidato SegundoGov { get => segundoGov; set => segundoGov = value; }
        public int VagasDisponiveisDepFederal { get => vagasDisponiveisDepFederal; set => vagasDisponiveisDepFederal = value; }
        public int VagasDisponiveisDepEstadual { get => vagasDisponiveisDepEstadual; set => vagasDisponiveisDepEstadual = value; }

        public void CalculoResultado()
        {
            List<Candidato> presidentes = new List<Candidato>();
            candidatos.Carregar();
            for (int i = 0; i < candidatos.MostrarCandidato().Count; i++)
            {
                if (candidatos.MostrarCandidato()[i].Cargo == "Presidente")
                {
                    presidentes.Add(candidatos.MostrarCandidato()[i]);


                }
            }

            for (int i = 0; i < presidentes.Count - 2; i++)
            {
                if (presidentes[i + 1].QntVotos > presidentes[i].QntVotos)
                {
                    PrimeiroPres = presidentes[i + 1];
                    SegundoPres = presidentes[i];
                }
                else
                {
                    PrimeiroPres = presidentes[i];
                    SegundoPres = presidentes[i + 1];
                }

            }

            List<Candidato> governadores = new List<Candidato>();
            for (int i = 0; i < candidatos.MostrarCandidato().Count; i++)
            {
                if (candidatos.MostrarCandidato()[i].Cargo == "Governador")
                {
                    governadores.Add(candidatos.MostrarCandidato()[i]);


                }
            }

            for (int i = 0; i < governadores.Count - 2; i++)
            {
                if (governadores[i + 1].QntVotos > governadores[i].QntVotos)
                {
                    PrimeiroGov = governadores[i + 1];
                    SegundoGov = governadores[i];
                }
                else
                {
                    PrimeiroPres = governadores[i];
                    SegundoPres = governadores[i + 1];
                }

            }
        }

    }
}
