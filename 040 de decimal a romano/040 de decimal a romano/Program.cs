using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_de_decimal_a_romano
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 10;
            Console.WriteLine(NumeroALetras(11.22));
            
        }
        static string DecenasARomadno(int num)
        {
            if (num <= 0)
            {
                return "";
            }
            else
            {
                string numstring = num.ToString();
                int[] numeros = new int[numstring.Length];

                int j = 0;
                for (int i = numstring.Length - 1; i >= 0; i--)
                {
                    numeros[j] = int.Parse(numstring[i].ToString());
                    j++;
                }

                string roma = "";
                for (int i = 0; i < numeros.Length; i++)
                {

                }




                return roma;
            }
        }

        static string NumeroALetras(double num)
        {
            int numEnteros = (int)num;
            int numdecimales = (int)Math.Round((num-numEnteros)*100,2);
            if (num - (int)num == 0)
            {
                return NumAVoice((int)num)+" PESOS";
            }
            else
            {
                return NumAVoice((int)num) + " PESOS CON " +NumAVoice((int)((num - (int)num)*10))+" CENTAVOS";
            }
        }
        static string NumAVoice(int num)
        {
            string numL = "";


            if (num == 1)
            {
                numL = "UNO";
            }
            else if (num == 2)
            {
                numL = "DOS";

            }
            else if (num == 3)
            {

                numL = "TRES";
            }
            else if (num == 4)
            {
                numL = "CUATRO";
            }
            else if (num == 5)
            {
                numL = "CINCO";

            }
            else if (num == 6)
            {
                numL = "SEIS";

            }
            else if (num == 7)
            {
                numL = "SIETE";

            }
            else if (num == 8)
            {
                numL = "OCHO";
            }
            else if (num == 9)
            {
                numL = "NUEVE";
            }
            else if (num == 10)
            {
                numL = "DIEZ";
            }
            else if (num == 11)
            {
                numL = "ONCE";
            }
            else if (num == 12)
            {
                numL = "DOCE";
            }
            else if (num == 13)
            {
                numL = "TRECE";
            }
            else if (num == 14)
            {
                numL = "CATORCE";
            }
            else if (num == 15)
            {
                numL = "QUICE";
            }
            else if (num < 20)
            {
                numL = "DIECI" + NumAVoice(num - 10);
            }
            else if (num == 20)
            {
                numL = "VEINTE";
            }
            else if (num > 20 && num < 30)
            {
                numL = "VEINTI" + NumAVoice(num - 20);
            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }
            else if (num == 2)
            {

            }
            else if (num == 3)
            {

            }


            return numL;
        }
    }
}
