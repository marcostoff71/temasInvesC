using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_colas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista.Add(6);
            lista.Add(7);
            lista.Add(8);


            Console.WriteLine(".............");
            Ccola cola1 = new Ccola();
            cola1.Agregar(1);
            cola1.Agregar(23);
            cola1.Agregar(23);
            cola1.Agregar(23);
            cola1.Agregar(23);
            cola1.Agregar(23);
            cola1.Agregar(23);
            cola1.infor();
            Console.WriteLine("Numero de elementos: " + cola1.count());
            int n;
            int l=cola1.count();

            for(int i = 0; i <l; i++)
            {
                n = cola1.eliminar();
                Console.WriteLine("Elemento eliminado: {0}", n);
                Console.WriteLine("Elemento eliminado: {0}", i);
            }

            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //try
            //{
            //    while (cola1.eliminar() != null)
            //    {
            //        Console.WriteLine("Elemento eliminado: " + cola1.eliminar());
            //    }
            //}
            //catch (Exception)
            //{

                
            //}
            //if (cola1.eliminar() != null) { 
                 
            //}

        }
    }
}
