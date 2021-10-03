using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_Trabajdno_con_matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[,] { { 1,2,3},
                                         { 4,5,6},
                                         { 7,8,9} };
            
            for(int f = 0; f < 3; f++)
            {
                for(int c = 0; c < 3; c++)
                {
                    Console.Write("{0}", matriz[c, f]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //imprimiendo solo las filas
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("{0} {1} {2}", matriz[0, f], matriz[1, f], matriz[2, f]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //imprimiendo solo las columnas
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("{0} {1} {2}", matriz[f, 0], matriz[f, 1], matriz[f, 2]);
                Console.WriteLine();
            }

            //Console.WriteLine(3.CompareTo(2));

            //string[] nombres = new string[] { "d", "e", "a" };
            ////BubbleSort(nombres);
            //BubbleSort(nombres);
            //nombres.ToList().ForEach(e =>
            //Console.WriteLine(e));
        }

        static void BubbleSort32(string[] nombres)
        {
            for (int i = 1; i < nombres.Length; i++)
            {
                for(int j = 0; j < nombres.Length - i; j++)
                {
                    if (nombres[j].CompareTo(nombres[j + 1]) > 0)
                    {
                        string aux;
                        aux = nombres[j + 1];
                        nombres[j + 1] = nombres[j];
                        nombres[j] = aux;
                    }
                }
            }
        }

        static void BubbleSort(IComparable[] arr)
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 1)
                    {
                        IComparable aux;
                        aux = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = aux;
                    }

                }
            }

        }
        
    }
}
