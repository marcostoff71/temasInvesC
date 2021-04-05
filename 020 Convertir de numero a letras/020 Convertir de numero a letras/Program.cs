using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Convertir_de_numero_a_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumeroALetras(11));
        }
        static string NumeroALetras(long num)
        {
            string letras="";
            switch (num)
            {
                case 1:
                    letras = "Uno";
                    break;
                case 2:
                    letras = "Dos";
                    break;
                case 3:
                    letras = "Tres";
                    break;
                case 4:
                    letras = "Cuatro";
                    break;
                case 5:
                    letras = "Cinco";
                    break;
                case 6:
                    letras = "Seis";
                    break;
                case 7:
                    letras = "Siete";
                    break;
                case 8:
                    letras = "Ocho";
                    break;
                case 9:
                    letras = "Nueve";
                    break;
                case 10:
                    letras = "Diez";
                    break;
                case 11:
                    letras = "Once";
                    break;
                case 12:
                    letras = "Doce";
                    break;
                case 13:
                    letras = "Trece";
                    break;
                case 14:
                    letras = "Catorce";
                    break;
                case 15:
                    letras = "Quince";
                    break;
            }
            if (num>15&&num < 20)
            {
                letras = "Dieci" + NumeroALetras(num % 10).ToLower();
            }

            return letras;
        }
    }
}
