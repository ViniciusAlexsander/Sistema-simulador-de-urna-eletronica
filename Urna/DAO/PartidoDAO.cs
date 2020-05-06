using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Urna
{
    public class PartidoDAO
    {
        private List<Partido> partidos;

        public PartidoDAO()
        {
            this.partidos = new List<Partido>();
        }


        public void AlterarVereador(Partido partido, int vagas)
        {
            partido.VagasVereador = vagas;
            Salvar();
        }
        public void Adicionar(Partido partido)
        {
            if (this.partidos.Count(p => p.Nome.Equals(partido.Nome)) > 0)
            {
                throw new Exception("Partido já foi cadastrado!");
            }
            else
            {
                this.partidos.Add(partido);
            }
        }

        public void Remover(Partido partido)
        {
            this.partidos.Remove(partido);
        }

        public List<Partido> MostrarPartidos()
        {
            return this.partidos;
        }


        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Partido>));
            FileStream fs = new FileStream(@"PartidosTop.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this.partidos);
            fs.Close();
        }
        static public string CriarNulo()
        {
            Partido partidonulo = new Partido
            {
                Nome = "Nulo",
                Numero = "00",
                Sigla = "NN"
            };
            return partidonulo.Nome;
        }
        public void Alterar(Partido partido, int vagas)
        {
            partido.VagasVereador = vagas;

        }

        public void ResetPartidos()
        {
            File.Delete(@"PartidosTop.xml");
        }


        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Partido>));
            FileStream fs = new FileStream(@"PartidosTop.xml", FileMode.OpenOrCreate);

            try
            {
                this.partidos = ser.Deserialize(fs) as List<Partido>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, this.partidos);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
