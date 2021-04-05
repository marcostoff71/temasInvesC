using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Expresiones_lamda
{
    class Program
    {
        delegate void miDelegado();
        static void Main(string[] args)
        {

            //expresiones lamda son funciones ananimas

            miDelegado d1 = new miDelegado(() => Console.WriteLine("hola"));//delegados apuntan una funcion
            Predicate<int> esPar = (i) => i % 2 == 0;//predicados dan como resultado un booleando
            Func<int, bool> esprimo = (item) =>
            {
                int cont = 0;
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Action mensaje = () => Console.WriteLine("hola");
            mensaje();
            Action hola = new Action(()=>Console.WriteLine("as"));

        }
        static void mensaje()
        {
            Console.WriteLine("hola");
        }
    }
}
