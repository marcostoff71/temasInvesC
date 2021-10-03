using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_Permutaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras = "Hola";
            Permutaciones(letras, 4);
        }
        static void Permutaciones(string cadena,int vuelta)
        {
            int n = cadena.Length;
            if (vuelta > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i != n - 1)
                    {

                        Console.Write(cadena[i]);
                    }
                    else
                    {
                        Console.Write(cadena[i]);
                    }
                    vuelta--;
                    Permutaciones(cadena, vuelta);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
