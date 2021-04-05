using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            ParImpar par1 = new ParImpar();
            do
            {
                Console.WriteLine("1. Saber si un numero es par o no");
                Console.WriteLine("2. Saber cuantos numero pares e impares tiene un numero");
                Console.WriteLine("3. Numero pares e impares Inicio y final");
                Console.WriteLine("4. Salir");
                do
                {
                    opcion = par1.ValidaInt("Escogue una opcion: ");

                } while (opcion < 1 || opcion > 4);
                switch (opcion)
                {
                    case 1:
                        par1.EsparImpar();
                        break;
                    case 2:
                        par1.CuantosParesImpares();
                        break;
                    case 3:
                        par1.ParImparIniciFin();
                        break;
                    case 4:
                        Console.Beep();
                        break;
                }

            } while (opcion!=4);
        }
        
    }
}
