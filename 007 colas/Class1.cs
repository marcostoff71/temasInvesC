using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_colas
{
    class Nodo
    {
        int dato;
        Nodo siguiente;

        public int Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
    class Ccola
    {
        Nodo inicio;
        Nodo fin;
        public Ccola()
        {
            inicio = null;
            fin = null;
        }
        //public int? eliminar()
        //{
        //    int a;
        //    if (inicio != null)
        //    {
        //        a= inicio.Dato;
        //        inicio = inicio.Siguiente;
        //        return a;
        //    }
        //    else
        //    {
        //        //throw new ArgumentException("NO existe ningun elemento");
        //        return null;
        //    }
        //}
        public int eliminar()
        {
            Nodo aux = inicio;
            int a;

            a = aux.Dato;
            inicio = aux.Siguiente;

            return a;

        }
        public void Agregar(int n)
        {
            Nodo temp = new Nodo();
            temp.Dato = n;
            temp.Siguiente = null;
            if (inicio == null)
            {
                inicio = temp;
            }
            else
            {
                fin.Siguiente = temp;
            }
            fin = temp;

            Console.WriteLine("Elemento agreado correctamente: " + n);
        }
        public void infor()
        {
            Nodo aux = inicio;

            if (aux != null)
            {
                while (aux != null)
                {
                    Console.Write("{0} ", aux.Dato);
                    aux = aux.Siguiente;

                }
                Console.WriteLine();
            }
        }
        public int count()
        {
            int cont = 0;
            Nodo aux = inicio;
            if (aux != null)
            {
                while (aux != null)
                {
                    cont++;
                    aux = aux.Siguiente;
                }
            }
            return cont;
        }
    }
}
