using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_EncontrarNumArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(numEncontra(10,new int[] {1,2,3,4,5,6,7,8}));
        }
        static bool numEncontra(int numBus,params int[] numeros)
        {
            int i=0, j=0;
            bool en = false;


            if (numeros != null)
            {
                i = 0;
                j = numeros.Length - 1;

                while (i < j)
                {
                    if (numeros[i] + numeros[j] == numBus)
                    {
                        en = true;
                        break;
                    }else if(numeros[i] + numeros[j] > numBus)
                    {
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }


            if (en)
            {
                Console.WriteLine("La suma de {0} en indice {1}",numeros[i],i);
                Console.WriteLine("Y la suma de {0} en indice {1}",numeros[j],j);
                Console.WriteLine("Da como resutlado {0} que es igual a {1}",numeros[i]+numeros[j],numBus);
            }
            return en;
        }
    }
}
