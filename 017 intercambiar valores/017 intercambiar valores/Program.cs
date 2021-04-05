using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_intercambiar_valores
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {

            int n1 = 2,n2=32;
            Console.WriteLine($"Valores antes del intercambio n1:{n1} n2:{n2}");
            IntercambioRef(ref n1, ref n2);
            Console.WriteLine($"Valores despues del intercambio n1:{n1} n2:{n2}");

            UsodeParsm(1,2,3,4,5);


            int readonlyArgument = 44;
            InArgExample(out readonlyArgument);
            Console.WriteLine(readonlyArgument);     // value is still 44

            void InArgExample(out int number)
            {
                // Uncomment the following line to see error CS8331
                number = 19;
            }

        }
        static void IntercambioRef(ref int n1,ref int n2)
        {
            int aux;


            aux = n1;
            n1 = n2;
            n2 = aux;
        }
        private static void UsodeParsm(params int[] nume)
        {
            for(int i = 0; i < nume.Length; i++)
            {
                Console.Write(nume[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
