using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Clase_Genericas
{
    class CLista <T>
    {
        public class Nodo
        {
            public T Dato { get; set; }
            public Nodo siguiente { get; set; }
        }
        private Nodo lista;

        public CLista()
        {
            lista = null;
        }
        public void EliminarAt(int indice)
        {
            if (indice >= 0 && indice < this.cont())
            {
                int cont = 0;
                Nodo aux = lista;
                Nodo anterior = null;

                while (aux.siguiente != null&&cont<indice)
                {
                    anterior = aux;
                    aux = aux.siguiente;
                    cont++;
                    
                }
                if (anterior == null)
                {
                    lista = lista.siguiente;
                }
                else
                {
                    anterior.siguiente = aux.siguiente;

                }
            }
        }
        public int cont()
        {
            int cont = 0;
            Nodo aux = lista;
            while (aux != null)
            {
                aux = aux.siguiente;
                cont++;
            }
            return cont;
        }
        public void Agregar(T dato)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;
            nuevoNodo.siguiente = null;

            if (lista == null)
            {
                lista = nuevoNodo;
            }
            else
            {
                Nodo aux = lista;
                while (aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                aux.siguiente = nuevoNodo;
            }
        }
        public void EliminarNodo(T dato)
        {
            if (lista != null)
            {
                Nodo aux1 = lista;
                Nodo anterior = null;
                while (aux1 != null && !aux1.Dato.Equals(dato))
                {
                    anterior = aux1;
                    aux1 = aux1.siguiente;
                }
                if (aux1 == null)
                {

                }else if (anterior == null)
                {
                    lista = lista.siguiente;
                }
                else
                {
                    anterior.siguiente = aux1.siguiente;
                }
            }
        }
        public Nodo ObtenerPorIndice(int indice)
        {
            if (indice >= 0&&indice<this.cont())
            {
                int cont = 0;
                Nodo aux = null;
                if (indice == 0)
                {
                    aux = lista;
                }
                else
                {
                    aux = lista;
                    while (cont < indice)
                    {
                        aux = aux.siguiente;
                        cont++;
                    }

                }
                return aux;
            }
            else
            {
                throw new ArgumentException("Indice fuera de los limites");
            }
            
        }
        Nodo aux = null;
        public T this[int index]
        {
            get { aux = ObtenerPorIndice(index);
                return aux.Dato;
            }
            set { aux = ObtenerPorIndice(index);
                aux.Dato = value;
            }
        }
    }
}
