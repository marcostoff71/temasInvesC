using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace _004_Pilas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stack pila = new Stack();
            //pila.Push(32);
            //pila.Push(44);

            //Console.WriteLine(pila.Peek());
            //Console.WriteLine(pila.Pop());
            //Console.WriteLine(pila.Pop());
            //Console.WriteLine(pila.Pop());

            Queue cola = new Queue();
            cola.Enqueue(23);
            cola.Enqueue(32);

            Console.WriteLine(cola.Count);
            Console.WriteLine(cola.Dequeue());
            Console.WriteLine(cola.Dequeue());


            Console.ReadKey();
            Console.Clear();
          
            pila pila2 = new pila();
            pila2.agregar(32);
            pila2.agregar(99);
            pila2.agregar(33);
            pila2.agregar(101);

            Console.WriteLine(pila2.elementos());
            pila2.mostrar();

            Console.WriteLine(pila2.eliminar());
            Console.WriteLine(pila2.eliminar());
            Console.WriteLine(pila2.eliminar());
            Console.WriteLine(pila2.eliminar());
            Console.WriteLine(pila2.eliminar());

            pila2.mostrar();



        }
    }
}
