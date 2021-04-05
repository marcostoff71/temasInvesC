using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class ParImpar
    {
        //Declaramos las varibles 
        private int inicio, final, total;


        public int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;

            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);

            return numFinal;
        }

        public void ParImparIniciFin()
        {
            inicio = ValidaInt("Dame el inicio: ");
            final = ValidaInt("Dame el final: ");
            for(int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("El numero {0} es par",i);
                }
                else
                {
                    Console.WriteLine("El numero {0} es impar",i);
                }
            }
        }
        public void EsparImpar()
        {
            bool espar=false;

            int num;
            //pedumos el numero
            num = ValidaInt("Dame el numero: ");
            if (num % 2 == 0)
            {
                espar = true;
            }
            else
            {
                espar = false;
            }
            
            if (espar == true)
            {
                Console.WriteLine("El numero {0} es par",num);
            }
            else
            {
                Console.WriteLine("El numero {0} es impar", num);
            }
        }

        public void CuantosParesImpares()
        {
            int num, pares = 0, impares = 0;
            num = ValidaInt("Dame el numero: ");
            for(int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("EL numero {0} tiene: {1} pares y: {2} impares", num, pares, impares);
        }
    }
}
