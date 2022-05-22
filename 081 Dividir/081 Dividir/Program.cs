using System;
using System.Collections.Generic;

namespace _081_Dividir
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program prog = new Program();

            /*
                        string nombre = "marco antonio gonzalez castelan @ lucers";
                        int i = nombre.IndexOf('g');
                        int j = nombre.LastIndexOf('@');

                        prog.EscribiendoCada(nombre, 2);

                        Console.WriteLine(prog.divi(20,9));
                        Console.WriteLine(30/199);*/
            prog.EscribiendoCadaWhile2("as3sas3", 2);

        }

        public string[] dividir(string str,int cada)
        {
            List<string> list = new List<string>();



            return list.ToArray();
        }
        public void mostrarString(string str,int i,int j)
        {
            int fin = j-i;
            fin +=1;
            Console.WriteLine(str.Substring(i, fin));
        }
        public void EscribiendoCada(string str,int cada,bool incluirResto=true)
        {
            int i=0;
            
            for(i = 0; i+cada <= str.Length; i = i + cada)
            {

                Console.WriteLine(str.Substring(i,cada));

            }

            int resto = str.Length % cada;
            if (resto>0&&incluirResto)
            {
                Console.WriteLine(str.Substring(i,resto));
            }


        }

        public void EscribiendoCadaWhile(string str,int cada,bool incluirResto=true)
        {
            int index=0;

            int resto = str.Length % cada;


            while (index+cada <= str.Length)
            {
                Console.WriteLine(str.Substring(index,cada));

                index += cada;
            }
            int resto2 = str.Length - index;

            if (resto2 > 0)
            {
                Console.WriteLine(str.Substring(index,resto2));
            }

            
        }
        public void EscribiendoCadaWhile2(string str,int cada)
        {
            int aux=cada;
            int ant=0;


            while (aux <= str.Length)
            {
                Console.WriteLine(str.Substring(ant,cada));
                ant = aux;
                aux += cada;
            }


            Console.WriteLine($"aux:{aux} ant:{ant}");


            int resto = str.Length - ant;
            if (resto>0)
            {
                Console.WriteLine(str.Substring(ant,resto));
            }



        }
        public int divi(int num, int entre)
        {
            int numAxu = num;
            int veces = 0;

            while (numAxu >= entre && numAxu > 0)
            {
                numAxu -= entre;
                veces++;
            }

            int numEAux = 0;
            int con2 = 0;
            int resto;
            while (num >= numEAux+entre)
            {
                numEAux += entre;
                con2++;
            }
            resto = num - numEAux;
            return con2;
        }
    }

}
