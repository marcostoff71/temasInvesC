using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;

namespace _026_ValidarEmailYRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Regex expre = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            Match esta=expre.Match("@marcoM12g.c");
            Console.WriteLine(esta.Success);
            Console.WriteLine(esta.Index);
        }
    }
}
