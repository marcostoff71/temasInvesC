using System;

namespace _068Prubas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new CPruebasOrdamiento();
            int[] arr = new int[10000];
            ob.LlenaArrayAleatorio(0, 100000, arr);
            ob.BubbleSort(arr);


            Console.WriteLine("Tiempo para ordenar: {0}ms",ob.TiempoEnMili);
            Console.WriteLine("Se dieron {0} iteraciones ",ob.Vueltas);
            Console.WriteLine("Lo que es igual a la longitud al cuadrado = {0}",(arr.Length)*(arr.Length));
        }
    }
}
