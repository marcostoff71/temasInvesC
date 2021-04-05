using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Pilas
{
    class Nodo
    {
        public int dato;
        public Nodo siguiente;
    }

    class pila
    {
        Nodo nodo;
        public pila()
        {
            nodo = null;
        }

        public void agregar(int n)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = n;
            nuevoNodo.siguiente = nodo;
            nodo = nuevoNodo;
        }
        public int eliminar()
        {
            int dato=-1;
            if (nodo != null)
            {
                dato = nodo.dato;
                nodo = nodo.siguiente;
            }
            else
            {
                Console.WriteLine("Vacio");
            }
            return dato;
        }
        public int elementos()
        {
            int cont=0;
            Nodo aux=nodo;
            while (aux != null)
            {
                cont++;
                aux = aux.siguiente;
            }

            return cont;
        }

        public void mostrar()
        {
            Nodo aux = nodo;
            while (aux != null)
            {
                Console.Write("{0} ", aux.dato);
                aux = aux.siguiente;
            }
            Console.WriteLine();
        }

    }
}
