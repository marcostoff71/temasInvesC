using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace _019_Expresiones_regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //expresiones regulares 
            //secunacias de caracteres que funcionan como un patro de busqueda
            //que buscan cadenas de caracteres letras,numeors, otros caracteres

            //clases utliles 
            //regex
            //match

        Regex r1 = new Regex(@"https?://(www.)?");
            
            string nombre="hola mu nombre es juan https://www.google.com";

           

            Match m1= r1.Match(nombre);
            
            Console.WriteLine(m1.Index);
            Console.WriteLine(m1.Success);
        }
    }
}
