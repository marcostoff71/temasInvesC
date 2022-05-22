using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.OleDb;

using Microsoft.Office.Interop;

namespace _070_FuncClass
{
    class Padre
    {
        public int numero;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Persona p = new Persona();
            p.numero = 22;
            Padre pa = p as Padre;
            Padre pe = new Padre();
            pe.numero = 233;
            Persona perr = pe as Persona;


            Console.WriteLine(perr.numero);

            Console.WriteLine(pa.numero);
            


        }
    }


    class Persona:Padre
    {

        private int edad;


        public Persona SetEdad(int e)
        {
            this.edad = e;


            return this;
        }


        public int GetEdad() => edad;


        public Persona AgreMasEdad(int e)
        {
            this.edad += e;



            return this;
        }
    }

}
