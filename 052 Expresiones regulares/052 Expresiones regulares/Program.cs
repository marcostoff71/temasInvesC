using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _052_Expresiones_regulares
{
    class Program
    {
        static void Main(string[] args)
        {

            string texto = "http://.com";
            Regex re = new Regex("^(?:(http|ftp|https|www)://()";

            
            Match d =re.Match(texto);
            Console.WriteLine(d.Success);
            Console.WriteLine(d.Value);
            Console.WriteLine(d.Index);
        }
    }
}
