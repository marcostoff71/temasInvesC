using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Clase_Genericas
{
    class Program
    {
        class Persona
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }
        static void Main(string[] args)
        {
            CLista<int> nuevaLista = new CLista<int>();
            nuevaLista.Agregar(2332);
            nuevaLista.Agregar(1);
            nuevaLista.Agregar(23);
            nuevaLista.Agregar(2);
            nuevaLista.Agregar(7);
            nuevaLista.EliminarAt(0);
            nuevaLista.EliminarNodo(1);

            Console.WriteLine("Elementeos: "+nuevaLista.cont());
            
            for(int i = 0; i < nuevaLista.cont(); i++)
            {
                Console.WriteLine(nuevaLista[i]);
            }
        }
    }
}
