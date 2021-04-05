using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_ExpresionesLamda
{
    class PracDelegados
    {
        private List<int> numeros = new List<int>();
        private delegate bool delefado(int num);
        private List<int> numerosPares = new List<int>();



        public void MostrarListas()
        {
            if (numeros.Count > 0)
            {

                numeros.ForEach(i => Console.WriteLine(i));
                if (numerosPares.Count > 0)
                {
                    numerosPares.ForEach(i => Console.WriteLine(i));
                }
                else mostrarMensaje(2);
            }
            else mostrarMensaje(1);
        }
        public void PedirNumeros()
        {
            int num = Validaciones.ValidaInt("Ingresa un numero: ");
            numeros.Add(num);


        }
        public void NumerosPares()
        {
            delefado d1 = new delefado(esPar);
            numerosPares.Clear();

            for (int i = 0; i < numeros.Count; i++)
            {
                if (d1(numeros[i]))
                {
                    numerosPares.Add(numeros[i]);
                }
            }
            if (numerosPares.Count > 0)
            {
                Console.WriteLine("\n\tLos numeros pares son");
                for (int i = 0; i < numerosPares.Count; i++)
                {

                    if (i != numerosPares.Count - 1)
                    {
                        Console.Write(numerosPares[i] + " , ");
                    }
                    else
                    {
                        Console.WriteLine(numerosPares[i]);
                    }
                }
                Console.WriteLine();
            }
            else mostrarMensaje(2);

        }
        public void SumaDeNumerosPares()
        {
            if (numerosPares.Count > 0)
            {
                delefado d1 = new delefado(esPar);
                int sumPares = 0;
                int sumImpares = 0;

                foreach (int num in numeros)
                {
                    if (d1(num))
                    {
                        sumPares += num;
                    }
                    else
                    {
                        sumImpares += num;
                    }
                }

                Console.WriteLine("La suma de los numeros pares es {0}", sumPares);
                Console.WriteLine("La suma de los numeros impares es {0}", sumImpares);
            }
            else mostrarMensaje(1);

        }
        public void mostrarMensaje(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sin numeros");
                    break;
                    
                case 2:
                    Console.WriteLine("Sin numeros pares");
                    break;
                case 3:
                    break;
            }
        }
        public void CualEsElNumeroPar()
        {
            int num;
            do
            {
                num = Validaciones.ValidaInt("Cual numero par es el: ");

            } while (num < 1); 

            int contPares=0;
            int numPar=0;
            delefado d1 = new delefado(esPar);


            while (contPares != num)
            {
                numPar++;
                if (d1(numPar))
                {
                    contPares++;
                    
                }
                
            }

            Console.WriteLine("El numero par: {0} es el {1}", num, numPar);
        }
        private bool esPar(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
