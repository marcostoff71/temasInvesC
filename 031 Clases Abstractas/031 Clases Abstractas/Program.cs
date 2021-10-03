using System;

namespace _031_Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class Animal
    {
        public int Nombre { get; set; }

        public virtual void NostrarNombre()
        {

        }

    }
    public class Perro : Animal
    {
        public override void NostrarNombre()
        {
            Console.WriteLine("hola lucer xd xd");
        }
    }

}
