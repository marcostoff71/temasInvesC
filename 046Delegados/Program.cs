using System;

namespace _046Delegados
{
    class Program
    {
        delegate int delegado(int n1,int n2);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            delegado suma= (n1,n2)=> {
                Console.WriteLine("Primer delegado");
                
                return n1 + n2;
                };
            suma += (n1, n2) => {

                Console.WriteLine("Segundo delegado");
                return n1 + n2;

            };
            Console.WriteLine(suma(1,2));
        }
        

    }
}
