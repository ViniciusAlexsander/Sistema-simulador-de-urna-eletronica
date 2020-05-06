using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Urna
{
    public class CandidatoDAO
    {
        private List<Candidato> candidatos;

        public CandidatoDAO()
        {
            this.candidatos = new List<Candidato>();
        }

        public void Adicionar(Candidato candidato)
        {
            if (candidato.Cargo == "Presidente" || candidato.Cargo == "Governador" || candidato.Cargo == "Prefeito")
            {
                this.candidatos.Add(candidato);
            }
            else
                if (this.candidatos.Count(c => c.Numero.Equals(candidato.Numero)) > 0)
            {
                throw new Exception("Candidato já cadastrado!");
            }
            else
            {
                this.candidatos.Add(candidato);
            }
        }

        public void Alterar(Candidato candidato, int voto)
        {
            candidato.QntVotos = voto;

        }




        public void Remover(Candidato candidato)
        {
            this.candidatos.Remove(candidato);
        }

        public List<Candidato> MostrarCandidato()
        {
            return this.candidatos;
        }


        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream(@"Candidatos.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this.candidatos);
            fs.Close();
        }
        public void CriarNulo()
        {
            Candidato presidentenulo = new Candidato()
            {
                Nome = "Presidente Nulo",
                Numero = "00",
                Idade = 0,
                Cargo = "Presidente",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };

            Candidato dfnulo = new Candidato()
            {
                Nome = "Deputado F Nulo",
                Numero = "001 ",
                Idade = 0,
                Cargo = "Deputado Federal",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };

            Candidato denulo = new Candidato()
            {
                Nome = "Deputado E Nulo",
                Numero = "005 ",
                Idade = 0,
                Cargo = "Deputado Estadual",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };

            Candidato governadornulo = new Candidato()
            {
                Nome = "Governador Nulo ",
                Numero = "00",
                Idade = 0,
                Cargo = "Governador",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };

            Candidato vereadornulo = new Candidato()
            {
                Nome = "Vereador Nulo ",
                Numero = "006",
                Idade = 0,
                Cargo = "Vereador",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };

            Candidato prefeitonulo = new Candidato()
            {
                Nome = "Prefeito Nulo ",
                Numero = "00",
                Idade = 0,
                Cargo = "Prefeito",
                Partido = PartidoDAO.CriarNulo(),
                QntVotos = 0
            };
            this.Adicionar(prefeitonulo);
            this.Adicionar(vereadornulo);
            this.Adicionar(presidentenulo);
            this.Adicionar(governadornulo);
            this.Adicionar(dfnulo);
            this.Adicionar(denulo);
            this.Salvar();

        }
        public void ResetEleicao()
        {
            File.Delete(@"Candidatos.xml");

        }

        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream(@"Candidatos.xml", FileMode.OpenOrCreate);

            try
            {
                this.candidatos = ser.Deserialize(fs) as List<Candidato>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, this.candidatos);
            }
            finally
            {
                fs.Close();
            }

        }







    }

    public class CandidatoException : ApplicationException
    {
        public CandidatoException(string message) : base(message) { }
    }
}
