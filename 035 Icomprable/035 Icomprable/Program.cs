using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _035_Icomprable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] num = new int[] { 1, 2, 3, 4, 5};

            Reverse1<int>(num);

            Console.WriteLine(2/2);

            Array.ForEach<int>(num, i => Console.WriteLine(i));

            List<Persona> lstPersonas = new List<Persona>();
            lstPersonas.Add(new Persona() { Edad = 23, Nombre = "as" });
            lstPersonas.Add(new Persona() { Edad = 11, Nombre = "as" });
            lstPersonas.Sort(new Comparison<Persona>(CompararPersona));


            lstPersonas.ForEach(i => Console.WriteLine(i.Edad));
        }
        private static int CompararPersona(Persona p1 ,Persona p2)
        {
            return p1.Edad.CompareTo(p2.Edad);
        }
        private static void Reverse1<T>(T[] arr)
        {



            //metodo 1
            int j=arr.Length-1;

            for(int i = 0; i < arr.Length/2; i++)
            {
               
                T aux;
                aux = arr[i];
                arr[i] = arr[j];
                arr[j] = aux;

                j--;       
            }


            //metodo 2
            int n = arr.Length / 2;
            int fin = arr.Length-1;
            for(int i = 0; i < n; i++)
            {
                T aux;
                aux = arr[i];
                arr[i] = arr[fin-i];
                arr[fin-i] = aux;
            }

            
        }
        private static int Media(int[]arr)
        {
            if (arr == null) return 0;
            int suma = 0;

            //froma numero 1 con expresiones lamda
            Array.ForEach<int>(arr,(int item) => suma += item);


            //forma numero 2 con iterador forEach
            foreach (int item in arr)
            {
                suma += item;
            }

            //forma numero 3 con ciclo for
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }

            return suma / arr.Length;

        }
        private static (int?,int?)  MayorNum(params int[] arr)
        {
            if (arr == null || arr.Length == 0) return (null,null);
            int mayor = arr[0];
            int menor = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > mayor)
                {
                    mayor = arr[i];
                }

                if (arr[i] < menor) menor = arr[i];
            }
            return (mayor,menor);
        }
    }
    class Persona
    {
       

        public int Edad { get; set; }
        public string Nombre { get; set; }

   

        
    }
}
