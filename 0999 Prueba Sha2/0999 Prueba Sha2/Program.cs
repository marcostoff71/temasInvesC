using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Security.Cryptography;

namespace _0999_Prueba_Sha2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Sha256("a"));
        }
        static string Sha256(string texto)
        {
            StringBuilder sb = new StringBuilder();

            SHA256 sha =SHA256Managed.Create();
            byte[]  resultado=sha.ComputeHash(Encoding.ASCII.GetBytes(texto));


            

            foreach  (byte item in resultado)
            {
                sb.Append(item.ToString("X2"));
            }
            Console.WriteLine(sb.Length);
            return sb.ToString();
        }
    }
}
