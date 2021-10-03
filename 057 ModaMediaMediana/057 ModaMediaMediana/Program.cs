using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_ModaMediaMediana
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             La media aritmética o promedio representa el reparto equitativo, el equilibrio, la equidad. Es el valor que tendrían los datos, si todos ellos fueran iguales. O, también, el valor que correspondería a cada uno de los datos de la distribución si su suma total se repartiera por igual.

            Si se ordenan todos los datos, de menor a mayor, la mediana es el valor que ocupa la posición central. Si el número de datos es par, la mediana es la media aritmética de los dos centrales.
 
            La moda es el valor que más se repite o, lo que es lo mismo, el que tiene la mayor frecuencia.
             */


            int[] numeros = new int[] { 3,3,3,3,3,4,4,4,4 };



            int[] mediana=ModaMediaMediana.CalculaMediana(numeros);

            ModaMediaMediana.MuestraArreglos(mediana);
            Console.WriteLine( ModaMediaMediana.CalculaModa(numeros));
            
        }
        
    }
}
