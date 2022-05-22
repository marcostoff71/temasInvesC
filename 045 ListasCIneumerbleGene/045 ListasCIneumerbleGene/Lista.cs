using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_ListasCIneumerbleGene
{
    class Lista<T>:IEnumerable<T>
    {
        public class Nodo
        {
            public T Item { get; set; }
            public Nodo Next { get; set; }
        }

        private Nodo lst;
        public Lista()
        {
            lst = null;
        }
        public int Count
        {
            get
            {
                int con = 0;
                Nodo aux = this.lst;
                while (aux != null)
                {
                    aux = aux.Next;
                    con++;
                }

                return con;
            }
        }

        public void Agregar(T item)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Item = item;
            nuevoNodo.Next = null;
            if (this.lst == null)
            {
                this.lst = nuevoNodo;
            }
            else
            {
                Nodo aux = lst;
                while (aux.Next != null)
                {
                    aux = aux.Next;
                }
                aux.Next = nuevoNodo;
            }
        }
        public void AgregarAt(T item,int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentException("El indice esta fuera de los limites");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Item = item;
                if (index == 0)
                {
                    nuevoNodo.Next = lst;
                    lst = nuevoNodo;
                }else
                {
                    Nodo auxInsertar = lst;
                    Nodo anterior = auxInsertar;
                    for(int i = 0; i < index; i++)
                    {
                        anterior = auxInsertar;
                        auxInsertar = auxInsertar.Next;
                    }

                    anterior.Next = nuevoNodo;
                    nuevoNodo.Next = auxInsertar;
                }
                
            }
        }
        public void Eliminar(T item)
        {
            if (lst != null)
            {

                Nodo auxBorrar=lst;
                Nodo anterior = null;

                while (auxBorrar!=null&&!auxBorrar.Item.Equals(item))
                {
                    anterior = auxBorrar;
                    auxBorrar = auxBorrar.Next;
                }

                if (auxBorrar == null)
                {

                }else if (anterior == null)
                {
                    lst = lst.Next;
                }
                else{
                    anterior.Next = auxBorrar.Next;
                }

            }
            
        }
        public Nodo ObtenerPorIndice(int index)
        {
            if (index < 0||index>=Count)
            {
                throw new ArgumentException("El indice esta fuera de los limites");
            }
            else
            {
                Nodo aux = lst;

                for (int i = 0; i < index; i++)aux=aux.Next ;

                return aux;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaEnum<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get {
                return ObtenerPorIndice(index).Item;
            }
            set { 
                ObtenerPorIndice(index).Item = value;
            }
        }

    }

    class ListaEnum<T> : IEnumerator<T>
    {
        private Lista<T> lst;
        private int positiion = -1;
        public ListaEnum(Lista<T> pList)
        {
            this.lst = pList;
        }
        public T Current {
            get
            {
                return lst[positiion];
            }
        }

        object IEnumerator.Current {

            get
            {
                return Current;
            }
        }
        

        public void Dispose()
        {
            lst = null;
        }

        public bool MoveNext()
        {
            positiion++;
            return (positiion < lst.Count);
        }

        public void Reset()
        {
            positiion = -1;
        }
    }
}
