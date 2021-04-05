using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_forech
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 1, 4, 5, 6, 7, 8, 9, 9 });
            numeros.FindAll(i => i % 2 == 0);
            int num=numeros.Where((a, e) => a == e).First();
            Console.WriteLine(num);
            
            foreach (int na in numeros)
            {
                
            }
           
        }
    }
}
