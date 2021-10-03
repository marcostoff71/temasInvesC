using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            //string texto = "marco";
            ////texto         01234

            //string copia = texto.Substring(1);
            ////copia        arco
            ////             0123


            ////ring texto = "marco";
            ////texto         01234
            ////len=5;
            ////len-3=2;
            //string copia2 = texto.Substring(3, texto.Length - 3);

            PathName("as");
          
           
        }

        static void PathName(string path)
        {
            string texto = "     dsdsds    ";
            Trim(ref texto);
            Console.WriteLine(texto);

            string patg = @"C:\34.jpg";
            //              012345678
            //utlima-3=6;

            int ultima = patg.LastIndexOf('\\')+1;
            //ultima=2+1=3
            Console.WriteLine(ultima);
            Console.WriteLine(patg.Length);
            Console.WriteLine(patg.Length-ultima);


            string nombre = patg.Substring(ultima,patg.Length-ultima);
            Console.WriteLine(nombre);
            Console.WriteLine(patg.Substring(0,patg.Length));
        }
        static void TrimStart(ref string texto)
        {
            if (!string.IsNullOrWhiteSpace(texto))
            {
                int conEspacio = 0;
                for(int i = 0; i < texto.Length; i++)
                {
                    if(texto[i]==' ')
                    {
                        conEspacio++;
                    }
                    else
                    {
                        break;
                    }
                }


                texto= texto.Substring(conEspacio, texto.Length - conEspacio);
            }
        }
        static void TrimEnd(ref string texto)
        {
            int con = texto.Length;
           for(int i = texto.Length - 1; i > 0; i--)
            {
                if (char.IsWhiteSpace(texto[i]))
                {
                    con--;
                }
                else
                {
                    break;
                }
            }
            texto = texto.Substring(0, con);

        }
        static void Trim(ref string texto)
        {
            TrimStart(ref texto);
            TrimEnd(ref texto);
        }
    }
}
