using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _047_Basee64
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = StringToBase64("hola");
            Console.WriteLine(b);
            Console.WriteLine(Base64ToString(b));

            
        }
        static string StringToBase64(string texto)
        {
            string base64;

            base64=Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(texto));

            return base64;
        }
        static string Base64ToString(string base64)
        {
            byte [] texto=Convert.FromBase64String(base64);


            return ASCIIEncoding.ASCII.GetString(texto);
        }
         
    }
}
