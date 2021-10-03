using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_ModaMediaMediana
{
    class ModaMediaMediana
    {
        public static void MuestraArreglos<T>(T[] arr)
        {
            Console.Write("[");
            if (arr != null)
            {

                for (int i = 0; i < arr?.Length; i++)
                {
                    if (i != arr.Length - 1)
                    {
                        Console.Write("{0},", arr[i]);
                    }
                    else
                    {
                        Console.Write("{0}", arr[i]);
                    }
                }
            }
            else
            {
                Console.Write("NULL");
            }
            Console.WriteLine("]");
        }
        static void SelectionSort(int[] items)
        {
            int min = 0;
            for (int i = 0; i < items.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                Swap<int>(ref items[i], ref items[min]);

            }
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T aux;
            aux = a;
            a = b;
            b = aux;
        }





        internal static decimal CalculaMedia(int[] items)
        {
            //return (decimal)items.Average();

            decimal suma = 0;
            int cantidad = items.Length;
            decimal pro = 0;

            for (int i = 0; i < items.Length; i++)
            {
                suma += items[i];
            }

            pro = suma / cantidad;
            return pro;
        }
        internal static int[] CalculaMediana(int[] items){

            int[] mediana;

            SelectionSort(items);
            if (items.Length % 2 == 0)
            {
                mediana = new int[2];

                int mita = (items.Length / 2);

                mediana[0] = items[mita-1];
                mediana[1] = items[mita];
            }
            else
            {
                mediana = new int[1];

                int mitad = (items.Length / 2);

                mediana[0] = items[mitad];
            }



            return mediana;
        }
        internal static int? CalculaModa(int[] items)
        {
            
            int? moda = null;
            int veces = 0;
            int anterior = 0;
            for (int i = 0; i < items.Length; i++)
            {
                veces = 0;
                
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[i] == items[j])
                    {
                        veces++;
                    }
                }



                //if (veces>1&&veces == anterior)
                //{
                //    moda = null;
                //}
                if (veces == anterior&&moda!=items[i])
                {
                    //Console.WriteLine("Veces: {0} Antior: {1}", veces, anterior);
                    moda = null;
                }
                else if (veces > 1 && veces > anterior)
                {

                    moda = items[i];
                    //Console.WriteLine("Numero moda actual:{0} numero de veces:{1} numero de veces anterior: {2}",moda,veces,anterior);
                    anterior = veces;
                }

            }




            return moda;


        }
    }
}
