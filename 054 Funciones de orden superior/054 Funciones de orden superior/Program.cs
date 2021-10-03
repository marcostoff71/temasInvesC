using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_Funciones_de_orden_superior
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CualEsNumPar(1));

        }
        static int CualEsNumPar(int numBusqueda)
        {
            int con = 0, numActual = 0;
            Predicate<int> Espar = (e) => e % 2 == 0;
            if (numBusqueda <= 0)
            {
                throw new ArgumentException("El numero a buscar debe ser mayor a 0");
            }
            while (con < numBusqueda)
            {
                numActual++;
                if (Espar(numActual)){
                    con++;
                }
                    
            }

            return numActual;


        }

        static void Fun(Action<int> hazAlgo,params int[] lstNumeros)
        {
            foreach (var item in lstNumeros)
            {
                hazAlgo(item);
            }
        }
    }
}
