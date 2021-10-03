using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _058_ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string emial = @"xontola@gma...com";
            string url = @"https://www.google.com";
            Regex re = new Regex("^[A-Za-z0-9.-]+@[A-Za-z0-9.-]+(.com|.net)$");



            Regex validaUrl = new Regex("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");




            bool mathc = validaUrl.IsMatch(url);
            Console.WriteLine("La cadena de caraceres es un email: {0}", mathc ? "Si" : "NO");
        }
    }
}
