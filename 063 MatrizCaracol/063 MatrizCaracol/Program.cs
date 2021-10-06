using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_MatrizCaracol
{
    class Program
    {
        enum Direccion
        {
            arriba,abajo,izquierda,derecha
        }
        static void Main(string[] args)
        {
            MuestraMatrizCorchetes(MatrizCaraCol(6, 4));
            mostrarMatriz(4, 6);
            MuestraMatrizSeparacion("\t", MatrizCara(6, 4));
        }
        private static void mostrarMatriz(int columnas, int filas)
        {
            bool derecha = true, izquierda = false, abajo = false;
            int[,] matrizc = new int[filas,columnas];
            int x = 0, y = -1;

            for (int k = 1; k <= columnas * filas; k++)
            {
                if (izquierda)
                {
                    y--;
                    if (y == -1)
                    {
                        y = 0; x--;
                        izquierda = false;
                    }
                    else if (matrizc[x,y] != 0)
                    {
                        y++; x--;
                        izquierda = false;
                    }
                }
                else if (derecha)
                {
                    y++;
                    if (y == columnas)
                    {
                        y = columnas - 1; x++;
                        derecha = false;
                        abajo = true;
                    }
                    else if (matrizc[x,y] != 0)
                    {
                        y--; x++;
                        derecha = false;
                        abajo = true;
                    }
                }
                else if (abajo)
                {
                    x++;
                    if (x == filas)
                    {
                        x = filas - 1; y--;
                        abajo = false;
                        izquierda = true;
                    }
                    else if (matrizc[x,y] != 0)
                    {
                        y--; x--;
                        abajo = false;
                        izquierda = true;
                    }
                }
                else
                {
                    x--;
                    if (x == -1 || matrizc[x,y] != 0)
                    {
                        x++; y++;
                        derecha = true;
                    }
                }

                matrizc[x,y] = k;
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizc[i,j] + "\t");
                }
                Console.WriteLine();
            }

            
        }
        static void MuestraMatrizCorchetes(int[,] matriz)
        {
            Console.Write("[");
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("[");

                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j != matriz.GetLength(1) - 1)
                    {
                        Console.Write($"{matriz[i,j]},");
                    }
                    else
                    {
                        Console.Write($"{matriz[i, j]}");
                    }
                }

                if (i != matriz.GetLength(0) - 1)
                {
                    Console.WriteLine("],");
                }
                else
                {
                    Console.Write("]");
                }
            }
            Console.WriteLine("]");
        }
        static void MuestraMatrizSeparacion(string sepa,int[,] matriz)
        {
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j != matriz.GetLength(1) - 1)
                    {
                        Console.Write($"{matriz[i, j]}{sepa}");
                    }
                    else
                    {
                        Console.Write($"{matriz[i, j]}");
                    }
                }
                Console.WriteLine();
            }
        }
        static int[,] MatrizCaraCol(int f,int c)
        {
            int[,] matriz = null;
            if (f >= 1 && c >= 1)
            {
                matriz = new int[f, c];
                int y = -1, x = 0;
                Direccion d = Direccion.derecha;
                int con = 1;
                for(int i = 0; i< f * c; i++)
                {
                    if (d == Direccion.derecha)
                    {
                        y++;
                        if (y == c)
                        {
                            y-=1;
                            x++;
                            d = Direccion.abajo;
                        }else if (matriz[y, x] != 0)
                        {
                            y -= 1;
                            x++;
                            d = Direccion.abajo;
                        }

                    }else if (d == Direccion.abajo)
                    {
                        x++;

                        if (x == f)
                        {
                            x--;
                            y--;
                            d = Direccion.izquierda;
                        }else if (matriz[x, y] != 0)
                        {
                            x--;
                            y--;
                            d = Direccion.izquierda;
                        }

                    }else if(d== Direccion.izquierda)
                    {
                        y--;

                        if (y == -1)
                        {
                            y=0;
                            x--;
                            d = Direccion.arriba;
                        }else if (matriz[x, y] != 0)
                        {
                            y++;
                            x--;
                            d = Direccion.arriba;
                        }
                    }else if (d == Direccion.arriba)
                    {
                        x--;
                        if (x == -1)
                        {
                            x++;
                            y++;
                            d = Direccion.derecha;
                        }else if (matriz[x, y] != 0)
                        {
                            x++;
                            y++;
                            d = Direccion.derecha;
                        }
                    }
                    matriz[x, y] = con++;
                }

            }


            return matriz;
        }
        static int[,] MatrizCara(int fila,int colum)
        {
            if (fila < 1 && colum < 1)
            {
                return null;
            }

            int[,] matriz = new int[fila, colum];
            int x = 0, y = -1;
            Direccion direActual = Direccion.derecha;
            int con = 1;
            for(int i = 0; i < fila * colum; i++)
            {

                if (direActual == Direccion.derecha)
                {
                    y++;

                    if (y == colum)
                    {
                        y--;
                        x++;
                        direActual = Direccion.abajo;
                    }else if (matriz[x, y] != 0)
                    {
                        y--;
                        x++;
                        direActual = Direccion.abajo;
                    }
                }else if (direActual == Direccion.abajo)
                {
                    x++;

                    if (x == fila||matriz[x,y]!=0)
                    {
                        x--;
                        y--;
                        direActual = Direccion.izquierda;
                    }
                }else if (direActual == Direccion.izquierda)
                {
                    y--;


                    if (y == -1)
                    {
                        y++;
                        x--;
                        direActual = Direccion.arriba;
                    }else if (matriz[x, y] != 0)
                    {
                        y++;
                        x--;
                        direActual = Direccion.arriba;
                    }
                }
                else
                {
                    x--;

                    if (x == -1)
                    {
                        x++;
                        y++;
                        direActual = Direccion.derecha;
                    }else if (matriz[x, y] != 0)
                    {
                        x++;
                        y++;
                        direActual = Direccion.derecha;
                    }
                }

                matriz[x, y] = con++;
            }


            return matriz;
        }
    }
}
