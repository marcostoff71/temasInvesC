using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("archivo.doc", FileMode.Append);

            Stopwatch tiempo = new Stopwatch();
            string fileWrite;
            tiempo.Start();
            fileWrite = "hsajbsajsjbssasakmsaksaksaas";
            fs.Write(ASCIIEncoding.ASCII.GetBytes(fileWrite), 0, fileWrite.Length);
            tiempo.Stop();

            Console.WriteLine("El tiempo trascurrido es {0}ms", tiempo.Elapsed.TotalMilliseconds);

            Console.WriteLine(Stopwatch.Frequency);
            


        }
    }
}
