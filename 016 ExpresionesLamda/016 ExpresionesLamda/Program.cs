using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_ExpresionesLamda
{
    class Program
    {
        //predicatos 
        //los predicados solo regresan booleanos 
        //sirven para predecir algo
        private Predicate<int> par = new Predicate<int>(i => i%2==0);
        //delegados

        private delegate int delegado(int a,int b);
        //para declarar un delegado se utiliza
        //[delgate][tipo que retorna][Nombre][parametros]
        //pueden regresar culquiere tipo de valor 
        //los delegados apuntan a un metodo

        private static void Main(string[] args)
        {
            Console.ForegroundColor =ConsoleColor.Cyan;
            PracDelegados pru1 = new PracDelegados();
            int op;
            void menu()
            {
                Console.WriteLine("1. Agregar numero");
                Console.WriteLine("2. Numeros pares");
                Console.WriteLine("3. Suma de numeros pares");
                Console.WriteLine("4. Cual es el numero par n");
                Console.WriteLine("5. Mostrar listas");
                Console.WriteLine("6. salir");
            }
            do
            {
                menu();
                
                do
                {
                    op = Validaciones.ValidaInt("Escogue una opcion: ");
                    if (op < 1 || op > 5)
                    {
                        Console.WriteLine("Escogue una opcion valida");
                    }
                } while (op < 1 || op > 5);

                switch (op)
                {
                    case 1:
                        pru1.PedirNumeros();
                        break;
                    case 2:
                        pru1.NumerosPares();
                        break;
                        
                    case 3:
                        pru1.SumaDeNumerosPares();
                        break;
                    case 4:
                        pru1.CualEsElNumeroPar();
                        break;
                    case 5:
                        pru1.MostrarListas();
                        break;

                }







                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (op != 6);
            Console.WriteLine("Adios xd");


        }
        
    }
}
