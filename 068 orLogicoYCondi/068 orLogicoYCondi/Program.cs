using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_orLogicoYCondi
{
    class Program
    {
        enum num
        {
            hola,nose,ds
        }
        static void Main(string[] args)
        {
            muestraSuma(num.ds|num.hola);
        }
        static void muestraSuma(num con)
        {
            if (con == num.ds)
            {
                Console.WriteLine("1");
            }else if (con == num.hola)
            {
                Console.WriteLine("3");
            }
            Console.WriteLine(con.ToString());
        }
    }
}
