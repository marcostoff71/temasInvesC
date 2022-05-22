using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace _071_ExpresionesValiPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string patH = @"\galeriahola.png";

            Regex re = new Regex(@"^([a-zA-z]:)?([\\]\w+)*\\((\w)+\.((\w){3}))");

            Regex validarMac = new Regex(@"");

            Action h = ()=>
            {
                Console.WriteLine("hola");
            };

            h.


             

        }
        static void ImprimeAlog<T>(T item)
        {
            Console.WriteLine(item);
        }
    }
}
