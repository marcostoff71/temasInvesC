using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 12, 2, 3 };
            Arbol arbol = new Arbol();
            arbol.Insertar(1);
            arbol.Insertar(2);
            arbol.Insertar(3);
            arbol.mostrarPost();
        }
    }
    class Arbol
    {
        public class Nodo
        {
            public int dato;
            public Nodo der;
            public Nodo izq;
        }

        private Nodo raiz;
        public Arbol()
        {
            this.raiz = null;
        }
        public void Insertar(int dato)
        {
            InsertarNodo(ref raiz, dato);
        }
        private void InsertarNodo(ref Nodo arbol,int dato)
        {
            if (arbol == null)
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.dato = dato;
                nuevoNodo.der = null;
                nuevoNodo.izq = null;

                arbol = nuevoNodo;
            }
            else
            {
                if (dato < arbol.dato)
                {
                    InsertarNodo( ref arbol.izq, dato);
                }
                else
                {
                    InsertarNodo(ref arbol.der, dato);
                }
            }
        }

        public void mostrarPost()
        {
            PostOrden(this.raiz);
        }
        public void PostOrden(Nodo arbol)
        {
            if (arbol == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(arbol.dato);
                PostOrden(arbol.der);
                PostOrden(arbol.izq);
            }
        }
    }
}
