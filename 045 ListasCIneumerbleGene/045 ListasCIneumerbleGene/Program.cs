
using System;
using System.Linq;

namespace _045_ListasCIneumerbleGene
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> lstEnteros = new Lista<int>();
            lstEnteros.Agregar(1);
            lstEnteros.Agregar(2);
            lstEnteros.Agregar(3);
            lstEnteros.Agregar(4);
            Console.WriteLine();
            Console.WriteLine(lstEnteros.Count);
            Console.WriteLine();

            for(int i = 0; i < lstEnteros.Count; i++)
            {
                Console.WriteLine(lstEnteros[i]);
            
            }

            lstEnteros.AgregarAt(1, 3);
            for (int i = 0; i < lstEnteros.Count; i++)
            {
                Console.WriteLine(lstEnteros[i]);
            }
            Console.WriteLine();
            foreach (var item in lstEnteros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            lstEnteros.ToList().ForEach(i => Console.WriteLine(i));
        }
    }
}
