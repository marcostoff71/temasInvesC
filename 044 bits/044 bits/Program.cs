using System;
using System.Collections;
using System.Text;

namespace _044_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto="Hola";
            BitArray arr = new BitArray(Encoding.ASCII.GetBytes(texto));
            PrintBits(arr);
        }
        static void PrintBits(BitArray arr)
        {
            string texto = "";
            int j = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i / 8 == j)
                {
                    texto += ",";
                    j++;
                }
                if (arr[i])
                {
                    texto += "1";
                }
                else
                {
                    texto += "0";
                }
            }

            char[] d =texto.ToCharArray();
            Array.Reverse(d);


            for(int i = 0; i < d.Length / 2; i++)
            {
                char aux;
                aux = d[d.Length - i - 1];
                d[d.Length - i - 1]=d[i];
                d[i] = aux;
            }
        }
    }
}
