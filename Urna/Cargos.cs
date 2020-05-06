using System.Collections.Generic;

namespace Urna
{
    public class Cargos
    {
        public string cargo;
        public int id;

        public static List<Cargos> Lista()
        {
            var lista = new List<Cargos>();
            var c1 = new Cargos();
            c1.id = 1;
            c1.cargo = "Deputado Estadual";
            lista.Add(c1);

            c1 = new Cargos();
            c1.id = 2;
            c1.cargo = "Deputado Federal";
            lista.Add(c1);

            c1 = new Cargos();
            c1.id = 3;
            c1.cargo = "Governador";
            lista.Add(c1);

            c1 = new Cargos();
            c1.id = 4;
            c1.cargo = "Prefeito";
            lista.Add(c1);

            c1 = new Cargos();
            c1.id = 5;
            c1.cargo = "Presidente";
            lista.Add(c1);

            c1 = new Cargos();
            c1.id = 6;
            c1.cargo = "Vereador";
            lista.Add(c1);

            return lista;
        }



    }
}
