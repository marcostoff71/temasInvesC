using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Expresiones_lamda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> datos1 = new List<int>{ 1, 2, 3, 4, 5 };

            List<int> datos2 = new List<int>() { 1, 2, 3, 4, 5 };




            var d = datos1.Join(;
                         


            Predicate<int> pe = (i) =>
            {
                if (i % 2 == 0) return true;
                else return false;
            };

            Predicate<int> es = new Predicate<int>(esPrimo);





        }

        static bool esPrimo(int num)
        {
            int con = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    con++;
                }
            }

            if (con == 2) return true;
            else return false;
        }
    }
}
