using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Util u1 = new Util();
            Console.WriteLine(u1.CualNumeroParEs(2));
        }
    }
    class Util
    {
        public bool esPrimo(int num)
        {
            int con = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    con+=1;
                }
            }
            if (con == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool esPar(int num)
        {
            return (num % 2 == 0) ? true : false;
        }
        public int CualNumeroPrimoEs(int numBu)
        {
            int con = 0;
            int numActual = 0;
            while (con <numBu)
            {
                numActual++;
                if (esPrimo(numActual))
                {
                    con++;
                }
            }

            return numActual;
        }
        public int CualNumeroParEs(int numBus)
        {
            int con = 0;
            int numActual = 0;
            while (con < numBus)
            {
                numActual++;
                if (esPar(numActual))
                {
                    con++;
                }
            }

            return numActual;
        }
    }
}
