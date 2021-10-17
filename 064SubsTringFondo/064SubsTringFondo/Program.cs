using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace _064SubsTringFondo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "marco";

            string path = "marco\\marco.txt";

            int indD = path.LastIndexOf("\\")+1;
            int indP = path.LastIndexOf('.');

            Console.WriteLine(indP);
            Console.WriteLine(path.Substring(0,path.Length-indP));
            Console.WriteLine(path.Substring(0,indP));
            Console.WriteLine(path.Substring(indD,path.Length-indD));

            //Console.WriteLine(NombreSinExtension(path));

            Console.ReadKey();
        }
        static string MuestraStringConIndice(string texto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(texto);
            sb.AppendLine("".PadRight(texto.Length, '^'));
            Enumerable.Range(0, texto.Length).ToList().ForEach(e =>
            {
                sb.Append(e);
            });


            return sb.ToString();
        }
        static string NombreConExtension(string ruta)
        {
            int ultimo = ruta.LastIndexOf('\\')+1;

            return ruta.Substring(ultimo , ruta.Length - ultimo);
            
        }
        static string NombreSinExtension(string ruta)
        {

            string re = NombreConExtension(ruta);

            int le = re.LastIndexOf('.')-1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(re.LastIndexOf('.'));
            Console.WriteLine(re.Length - re.LastIndexOf('.'));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            re = re.Substring(0, re.Length - le);

           

            /*if (le != -1)
            {
                re = re.Substring(0, le);
            }*/
            return re;

        }
    }
}
