using System;
using System.Collections.Generic;

namespace _036_ExisteDentroDEArry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> lstEnteros = new List<string>() { "marcO", "antoni", "gonza" };
            Console.WriteLine(Existe(lstEnteros,i=>i.ToLower().Contains("marco".ToLower())));
            Console.WriteLine(Existe(lstEnteros,"marcO"));

            lstEnteros.Sort((i, e) => i.CompareTo(e));



            lstEnteros.ForEach(i => Console.WriteLine(i));
        }
        static bool Existe<T>(IEnumerable<T> lista, Predicate<T> condi)
        {

            bool valor=false;


            foreach (var item in lista)
            {
                if (condi(item))
                {
                    valor = true;
                    break;
                }
            }


            return valor;
        }
        static bool Existe(IEnumerable<string> lista, string valor)
        {
            foreach (var item in lista)
            {
                if (item.Trim().ToLower() == valor.ToLower().Trim())
                {
                    return true;
                }
            }


            return false;
        }
        static bool Existe<T>(IEnumerable<T> lista,T valor)
        {
            foreach (var item in lista)
            {
                if (item.Equals(valor))
                {
                    return true;
                }
            }


            return false;
        }

    }
}
