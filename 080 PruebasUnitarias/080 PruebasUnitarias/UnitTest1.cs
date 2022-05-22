using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;

namespace _080_PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public string JoinLetras(char separador = ',', char final = 'y', params string[] arr)
        {

            if (arr == null)
            {
                throw new ArgumentNullException("Array nulo");
            }


            StringBuilder sb = new StringBuilder();

            //Si el arreglo tiene mas de un elemento
            if (arr.Length > 1)
            {
                //Restamos uno porque al ultimo le agregaremos el caracter final
                int longitud = arr.Length - 1;

                //Creamos el bucle hasta la longitud -1
                //Es decir si tenmos un arreglo con 10 archivos recorremos 9
                for (int i = 0; i < longitud; i++)
                {
                    //vamos añadiendo nuestro arreglo
                    sb.Append(arr[i]);


                    if (i != longitud - 1)
                    {
                        sb.Append(separador);
                        sb.Append(" ");
                    }


                }

                sb.Append(" ").Append(final).Append(" ").Append(arr[arr.Length - 1]);
            }
            else if (sb.Length == 1)
            {
                sb.Append(arr.Last());
            }


            return sb.ToString();

        }
    }
}

