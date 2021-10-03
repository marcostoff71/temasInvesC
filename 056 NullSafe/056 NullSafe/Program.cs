using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_NullSafe
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p=null;

            Console.WriteLine(p?.Edad > 10);
            MuestraPersona(p);
        }
        static void MuestraPersona(Persona p1)
        {
            Console.WriteLine(p1?.Edad == 2);
            if (p1?.Edad == 2)
            {
                Console.WriteLine("La edad de esa persona es igual a 2");
            }
            Console.WriteLine("hola");
            Console.WriteLine(p1?.Edad);
            Console.WriteLine("hola");
        }
    }
    class Persona
    {
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
