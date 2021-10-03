using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
    class Ser
    {
        public bool Vivo { get; set; }
    }
    class Persona : Ser
    {
        public string Nombre { get; set; }
    }
}
