using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_MetodosOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            

            PiedraPaPel();
            Console.WriteLine(FuerzaBruta("marco43saSAds. "));
            int[] numeros = { 6, 5, 4, 3, 2, 1 };
            MuestraArray(numeros);
            SelecionSort(numeros);
            MuestraArray(numeros);

            int[,] ma = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            ElemetentosEnDiagonal(ma);
            int[] dados = new int[3];
            Random rdn = new Random();
            for(int i = 0; i < dados.Length; i++)
            {
                dados[i]=rdn.Next(1,7);
            }
            MuestraArray(dados);
        }
        static void PiedraPaPel()
        {
            Random rdn = new Random();
            string[] palabrasNece = { "PIEDRA", "PAPEL", "TIJERA" };
            string j1;
            string j2;

            j1 = palabrasNece[rdn.Next(palabrasNece.Length)];
            j2 = palabrasNece[rdn.Next(palabrasNece.Length)];


            Console.WriteLine("Jugaor 1: {0} Jugador 2: {1}", j1, j2);
            if (j1 == j2)
            {

                Console.WriteLine("Esto es un empate");
            }else if (j1 == "PIEDRA" && j2 == "TIJERA")
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }else if(j2 == "PIEDRA" && j1 == "TIJERA")
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }else if (j1 == "PAPEL"&& j2 == "PIEDRA")
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }else if (j2 == "PAPEL" && j1 == "PIEDRA")
            {
                Console.WriteLine("gANO EL JUGADOR 1");
            }else if(j1=="TIJERA"&&j2=="PAPEL")
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }else if(j2 == "TIJERA" && j1 == "PAPEL")
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }

        }
        static string FuerzaBruta(string textoOri)
        {
            StringBuilder generado = new StringBuilder(textoOri.Length);
            generado.Append("".PadRight(textoOri.Length));
            Random rnd = new Random();
            string letrasMinus = "abcdefghijklmnñopqrstvwxyz";
            string letrasMayus = letrasMinus.ToUpper();
            string numeros = "1234567890";
            string simbolos = "!'\"#$%&/.,-{{}´+";
            int intentos = 0;
            for(int i = 0; i < textoOri.Length; i++)
            {
                while (textoOri[i] != generado[i])
                {
                    char sim = textoOri[i];
                    char gene=' ';
                    if (char.IsLower(sim))
                    {
                        gene = letrasMinus[rnd.Next(letrasMinus.Length - 1)];
                    }else if (char.IsUpper(sim))
                    {
                        gene = letrasMayus[rnd.Next(letrasMayus.Length - 1)];
                    }else if (char.IsDigit(sim))

                    {
                        gene =numeros[rnd.Next(numeros.Length - 1)];

                    }else if (char.IsWhiteSpace(sim))
                    {
                        gene = ' ';
                    }
                    else
                    {
                        gene = simbolos[rnd.Next(simbolos.Length - 1)];

                    }
                    generado[i] = gene;
                    intentos++;
                    
                }
                intentos++;
            }
            Console.WriteLine("Su contraseña fue adivinada en: {0} intentos",intentos);

            return generado.ToString();

        }
        static void MuestraArray<T>(T[] arr)
        {
            
            if (arr != null)
            {
                Console.Write("[");

                for(int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        Console.Write(arr[i]);
                    }
                    else
                    {
                        Console.Write("{0},",arr[i]);
                    }
                }

                Console.WriteLine("]");
            }
        }
        static void ElemetentosEnDiagonal(int[,] matriz)
        {
            if (matriz != null)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for(int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.Write(" {0} ",matriz[i,j]);
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (j>i)
                        {
                            Console.Write(" {0} ", matriz[i, j]);
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (j<i)
                        {
                            Console.Write(" {0} ", matriz[i, j]);
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        static void BubleSort(params int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i; j++)
                {
                    if (arr[j].CompareTo(arr[j+1])>0)
                    {
                        int aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }
            }
        }
        static void InsertionSort(params int[] arr)
        {
            int pos,temp;
            for (int i = 1; i < arr.Length; i++)
            {
                pos = i;

                while (pos > 0 && arr[pos - 1].CompareTo(arr[pos]) > 0)
                {
                    temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
        }
        static void SelecionSort(params int[] arr)
        {
            int iMin, temp;
            for (int i = 0; i < arr.Length; i++)
            {
                iMin = i;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[iMin]) < 0)
                    {
                        iMin = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }
        }
    }

    class persona : IComparable<persona>
    {
        public int edad { get; set; }
        
        public int CompareTo(persona obj)
        {
            return edad.CompareTo(obj.edad);
        }
    }
}
