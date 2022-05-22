using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _068Prubas
{
    class CPruebasOrdamiento
    {
        private Stopwatch stop;
        private long vueltas;
        public long Vueltas { get=>vueltas; }
        public int TiempoEnMili { get => (int)stop.ElapsedMilliseconds; }


        public CPruebasOrdamiento()
        {
            this.vueltas = 0;
            this.stop = new Stopwatch();
        }
        
        private void MuestraTitulo(string titulo,ConsoleColor color)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("".PadRight(titulo.Length + 4, '-'));
            sb.AppendLine(string.Format("| {0} |",titulo));
            sb.AppendLine("".PadRight(titulo.Length + 4, '-'));
            Console.ForegroundColor = color;
            Console.WriteLine(sb);
            Console.ResetColor();
        }
        public void LlenaArrayAleatorio(int min=0,int max=1000,params int[] arr)
        {
            Random rdn = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rdn.Next(min, max);
            }
        }
        public void MuestraArray(params int[] arr)
        {
            Console.Write("[");

            for (int i = 0; i < arr.Length; i++)
            {

                if (i != arr.Length - 1)
                {
                    Console.Write("{0},",arr[i]);
                }
                else
                {
                    Console.Write("{0}",arr[i]);

                }
            }

            Console.WriteLine("]");
        }
        public void BubbleSort(params int[] arr)
        {
            this.vueltas = 0;
            int temp;

            MuestraTitulo("Arreglo original", ConsoleColor.Green);

            MuestraArray(arr);

            this.stop.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    vueltas++;
                }
            }
            this.stop.Stop();
            MuestraTitulo("Arreglo Ordenado", ConsoleColor.Cyan);
            MuestraArray(arr);
        }
        public void BubbleSortProcedimientos(params int[] arr)
        {
            void MuestraComparacion(int a,int b)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0} es mayor que {1} - {2}",a,b,a>b?"SI":"NO");
                Console.WriteLine("{0}",a>b?" se hara un intercambio":" se hara un intercambio");
                Console.ResetColor();
            }

            MuestraTitulo("Arreglo original", ConsoleColor.Green);
            MuestraArray(arr);

            MuestraTitulo("Ordenando arreglo", ConsoleColor.Cyan);
            int temp;
            this.stop.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    Console.WriteLine(" Indice i={0}  Indice j={1} indice j+1={2}",i,j,j+1);
                   
                    MuestraComparacion(arr[j], arr[j + 1]);
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                        MuestraArray(arr);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            this.stop.Stop();
        }

    }
}
