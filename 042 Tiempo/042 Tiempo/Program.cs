using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _042_Tiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingresa el mes de tu cumpleaños: ");
                int mesCumple = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el dia de tu cumpleaños: ");
                int diaCumple = int.Parse(Console.ReadLine());
                DateTime actual = DateTime.Now;
                DateTime siguieten;

                if (actual.Month > mesCumple)
                {
                    siguieten = new DateTime(actual.Year+1, mesCumple, diaCumple);

                }
                else if(actual.Month==mesCumple)
                {

                }
                
                
               
            }
            
        }
    }
}
