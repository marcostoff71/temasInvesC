using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Moda_Media.Mediana
{
    class Program
    {
        /*
         La media aritmética o promedio representa el reparto equitativo, el equilibrio, la equidad. Es el valor que tendrían los datos, si todos ellos fueran iguales. O, también, el valor que correspondería a cada uno de los datos de la distribución si su suma total se repartiera por igual.
        Si se ordenan todos los datos, de menor a mayor, la mediana es el valor que ocupa la posición central. Si el número de datos es par, la mediana es la media aritmética de los dos centrales.

        La moda es el valor que más se repite o, lo que es lo mismo, el que tiene la mayor frecuencia.*/
        static void Main(string[] args)
        {
            float[] arr = new float[] { 6, 5,5,5,5,5, 4, 2, 1, 66,66,66 };
            float[] mediana = Mediana(arr);

            if (mediana.Length < 2)
            {
                Console.WriteLine("La mediana es {0}", mediana[0]);
            }
            else
            {
                Console.WriteLine("La mediana es {0} y {1}", mediana[0], mediana[1]);
            }
            Console.WriteLine($"La media es {Media(arr)}");

            Console.WriteLine($"La moda es {Moda(arr)}");


            var numeros = new int[] { 4, 3, 2, 1 };
            Array r1 = new int[23];
            Array.Sort(r1);


            Reverse(numeros);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Moda(new int[] { 2,1}));

        }
        /// <summary>
        /// Media o promedio
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Media</returns>
        static float Media(float[] arr)
        {
            float pro = 0, suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }


            pro = suma / arr.Length;

            return pro;
        }
        /// <summary>
        /// La mediana es la el numero en la mitad en caso de se par se toman los dos del centro
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>retorn un float de 1 o 2 elementos</returns>
        static float[] Mediana(float[] arr)
        {
            //ordenamos de mayor a menor
            SelectionSort(arr);


            //creamos el array que tendra los valores 1 si es impar y 2 si es par
            float[] medio;
            //comprobamos cual es la mitad del arry
            int mitad = arr.Length / 2;

            if (arr.Length > 0)
            {

                if (arr.Length % 2 == 0)
                {
                    medio = new float[2];
                    medio[0] = arr[mitad - 1];
                    medio[1] = arr[mitad];
                }
                else
                {
                    medio = new float[1];
                    medio[0] = arr[mitad];
                }
            }
            else
            {
                throw new ArgumentException("El array esta vacio");
            }

            return medio;
        }
        static void SelectionSort(float[] arr)
        {
            int imin;
            float aux;
            if (arr.Length > 1)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    imin = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[i])
                        {
                            imin = j;
                        }
                    }

                    aux = arr[i];
                    arr[i] = arr[imin];
                    arr[imin] = aux;

                }
            }
        }
        static float Moda(float[] arr)
        {
            float numRe=0;
            if (arr == null)
            {
                throw new ArgumentException("Instancia a objeto no inicialido");
            }
            else if (arr.Length <= 0)
            {

                throw new ArgumentException("Arry vacio");
            }
            else
            {
                int veces = 0;
                int vecesAux=0;
                float num;
                float numAux;
                for(int i = 0; i < arr.Length; i++)
                {
                    numAux = arr[i];
                    vecesAux = 0;

                    for(int j = 0; j < arr.Length; j++)
                    {
                        if (numAux == arr[j]) vecesAux++;
                        
                    }
                    if (vecesAux>veces)
                    {
                        veces = vecesAux;
                        num = arr[i];
                        numRe = num;
                    }
                }
            }

            return numRe;
        }
        static void Reverse(float[] arr)
        {
            if (arr != null)
            {

                int n = arr.Length / 2;
                Console.WriteLine("La mitad del arry es: {0}", n);
                for (int i = 0; i < n; i++)
                {
                    int primero = i;
                    int ultimo = arr.Length - i - 1;

                    Console.WriteLine("Primero indice: {0}", primero);
                    Console.WriteLine("Utlimo indice: {0}", ultimo);

                    float aux;
                    aux = arr[primero];
                    arr[primero] = arr[ultimo];
                    arr[ultimo] = aux;
                }
            }
        }
        static void Reverse<T>(T[] arr)
        {
            int m = arr.Length / 2;
            T aux;
            for (int i = 0; i < m; i++)
            {
                aux = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1]=aux;
            }
        }
        static T Moda<T>(T[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Objeto no instanciado");
            }
            else
            {
                T itemDato=arr[0],itemDatoAux;
                int con = 0, conAux;

                for (int i = 0; i < arr.Length; i++)
                {
                    conAux = 0;
                    itemDatoAux = arr[i];
                    for(int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j].Equals(itemDatoAux)) conAux++;
                    }

                    if (conAux > con)
                    {
                        con = conAux;
                        itemDato = itemDatoAux;
                    }
                }
                return itemDato;
            }

        }

    }
}
