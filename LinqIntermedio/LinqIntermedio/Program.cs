using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntermedio
{
    class Program
    {
        class Persona
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
            public string NombreYedad { get
                {
                    return $"{Edad} - {Nombre}";
                } }
        }

        static void Main(string[] args)
        {

            List<Persona> lstPersonas = new List<Persona>()
            {
                new Persona(){Edad=12,Nombre="Marco1"},
                new Persona(){Edad=23,Nombre="Marco2"},
                new Persona(){Edad=23,Nombre="Marco3"},
                new Persona(){Edad=32,Nombre="Marco4"}
            };
            List<string> NombreYedad = new List<string>()
            {
                "23 - Marco45",
                "44 - Marco45",
                "54 - Marco4",
                "65 - Marco5",
            };


            List<string> lstNombreYedad = (from d in (
                                           from d in
                                           lstPersonas
                                           select d.NombreYedad).Union
                                           (from d in NombreYedad select d)
                                           orderby d descending
                                           select d
                                           ).ToList();

            

            lstNombreYedad.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
