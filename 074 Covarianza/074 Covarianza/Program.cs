using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Covarianza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 2323232;



            Console.WriteLine("\tNumero en decimal: {0}",num);
            BitArray reConversion=DecimalABinarioBit(num);
            Span(3);

            Console.Write("\tImprime bits: ");
            ImprimeBitAryy(reConversion);
            Span(3);

            

            Console.WriteLine("\tCantidad de bits: {0}",reConversion.Length);
            Span(3);
            
            
            
        }
        public static void Span(int can)
        {
            while (can > 0)
            {
                Console.WriteLine();
                can--;
            }
        }
        public static void ImprimeBitAryy(BitArray bt)
        {
           for(int i = 0; i < bt?.Length; i++)
            {
                if (bt[i])
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }

                if (i == bt.Length - 1)
                {
                    Console.WriteLine();
                }
            }

        }
        public static BitArray DecimalABinarioBit(int num)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(DecimalABinarioString(num));


            BitArray result = new BitArray(sb.Length);

            for(int i=0;i<sb.Length; i++)
            {
                if (sb[i] == '0')
                {
                    result[i] = false;
                }
                else
                {
                    result[i] = true;
                }

            }
            return result;
        }
        public static string DecimalABinarioString(int num)
        {

            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                sb.Append(num % 2);
                num /= 2;
            }
            for (int i = 0, j = sb.Length - 1; i < sb.Length / 2; i++, j--)
            {
                char aux = sb[i];
                sb[i] = sb[j];
                sb[j] = aux;
            }
            return sb.ToString();
        }

    }
    public class Nose<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public interface Base<out T>
    {
        
        T count { get; }

        T nose { get; }
        void metodo();

    }

    public class Hijo<T> : Base<T>
    {
        public T count => throw new NotImplementedException();

        public T nose => throw new NotImplementedException();

        public void metodo()
        {
            throw new NotImplementedException();
        }
    }
}
