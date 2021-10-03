using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_GeneraCodigos
{
    public class LCodigos
    {
        private string GeneCodigo(int lon)
        {
            string dic = "abcdefghijklmopqrstvwxyz";
            dic += dic.ToUpper();
            dic += "1234567890";

            string gene = "";
            
            for (int i = 0; i < lon; i++)
            {
                int indiLetra = new Random(323243).Next(dic.Length - 1);
            
                gene += dic[indiLetra].ToString();
            Console.WriteLine(dic);
            Console.WriteLine(dic[new Random().Next(dic.Length-1)]);
            }

            Console.WriteLine("Gene {0}",gene);
            return gene;

        }

        public string ObtieneCodigoUnico(IEnumerable<string> codigos, int lon = 10)
        {
            bool correcto = false;
            string codi;
            do
            {
                correcto = true;
                codi = GeneCodigo(lon);

                foreach (var item in codigos)
                {
                    if (item == codi)
                    {
                        correcto = false;
                        break;
                    }
                }
                //correcto = !codigos.Any(e => e.ToLower() == codi.ToLower());

            } while (!correcto);
            Console.WriteLine("Codigo gene={0}",codi);
            return codi;
        }
        public string ObtieneCodigo(int lon = 10)
        {
            string codi = GeneCodigo(lon);

            return codi;
        }

    }
}
