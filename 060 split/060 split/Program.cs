using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _060_split
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex re = new Regex("(http|https)://[\\w\\W]+");
            Console.WriteLine(re.IsMatch("http://marco"));

            string[] textos =Regex.Split("marcoo", "\\W{3}");
            for (int i = 0; i < textos.Length; i++) Console.WriteLine(textos[i]);
        }
        static string[] splitAt(string texto,int cada)
        {

            
            int cadaAux = cada;
            int pos = 0;
            List<string> split = new List<string>();

            for(int i = 0; i < texto.Length; i++)
            {

                if (i == cadaAux)
                {

                    split.Add(texto.Substring(pos, cada));
                    cadaAux += cada;
                    pos = i;
                }
            }


            if (pos < texto.Length)
            {
                split.Add(texto.Substring(pos));
                Console.WriteLine("pos:{0} longitud:{1}", pos, texto.Length);
            }


            return split.ToArray();
        }
    }
}
