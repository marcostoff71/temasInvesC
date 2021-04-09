using System;
using System.Collections.Generic;
using System.Linq;
namespace _029_CrearNuevoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 23, 4, 54, 3 };

            List<int> d=new List<int>() { 23,23,}.Concat(numeros.Concat(numeros)).ToList();
            d.ForEach(c => Console.WriteLine(c));

            Console.WriteLine("----------------------");

            List<int> nuevaVersion = numeros.Select(I => I * 2).ToList();
            nuevaVersion.ForEach((int e) =>Console.WriteLine(e));
           
        }
    }
}
