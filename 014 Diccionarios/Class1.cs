using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _014_Diccionarios
{
    class Cvali
    {
        public string ValidaString(string mensaje)
        {
            string final = "";
            bool esLetra = false;
            while (final == "" || esLetra == false)
            {
                esLetra = true;
                Console.Write(mensaje);
                final = Console.ReadLine().Trim();

                for (int i = 0; i < final.Length; i++)
                {
                    if (char.IsDigit(final[i]))
                    {
                        esLetra = false;
                        break;
                    }

                }

            }

            return final;
        }
        public int validaInt(string mensaje)
        {
            int numFinal = 0;
            bool valor = false;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (!valor);
            return numFinal;
        }
        public int validaInt(string mensaje, int min)
        {
            int numFinal = 0;
            bool valor = false;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (!valor || numFinal < min);
            return numFinal;
        }
        public int validaInt(string mensaje, int min, int max)
        {
            int numFinal = 0;
            bool valor = false;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (!valor || numFinal < min || numFinal > max);
            return numFinal;
        }
    }
    class CDic
    {
        Dictionary<string, int> productos = new Dictionary<string, int>();
        Cvali vali1 = new Cvali();
        public void Menu()
        {

            
            int op;
            do
            {
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Mostrar");
                Console.WriteLine("5. Salir");
                op = vali1.validaInt("Escogue una opcion: ", 1, 5);
                switch (op)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Eliminar();
                        break;
                    case 3:
                        Buscar();
                        break;
                    case 4:
                        Mostrar();
                        break;
                }
                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (op != 5);
        }
        public void Agregar()
        {
            string producto = "";
            int precio = 0;
            try
            {
                producto = vali1.ValidaString("Dame el nombre del producto: ");
                precio = vali1.validaInt("Dame el precio: ", 1);
                productos.Add(producto, precio);
            }
            catch (Exception e)
            {
                Console.WriteLine("producto existente");
            }
        }
        public void Eliminar()
        {
            string eliminar = "";
            if (productos.Count > 0)
            {

                eliminar = vali1.ValidaString("Dame el producto a eliminar: ");

                if (productos.ContainsKey(eliminar))
                {
                    try
                    {
                        productos.Remove(eliminar);
                        Console.WriteLine("Producto {0} eliminado", eliminar);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Error al eliminar");
                    }
                }
                else
                {
                    Console.WriteLine("No hay ningun producto con el nombre {0}", eliminar);
                }
                
            }
        }
        public void Buscar()
        {
            string nombre = "";
            if (productos.Count() > 0)
            {
                nombre= vali1.ValidaString("Dame el nombre del producto a buscar: ");

                if (productos.ContainsKey(nombre))
                {
                    Console.WriteLine("El producto: {0} esta en el diccionario",nombre);
                }
            }
        }
        public void Mostrar()
        {
            if (productos.Count() > 0)
            {
                foreach(KeyValuePair<string,int> pro in productos)
                {
                    Console.WriteLine("Producto: {0} precio: {1}", pro.Key, pro.Value);
                }
            }
            else
            {
                Console.WriteLine("Vacio");
            }
        }
        
        


        //constructor
        public CDic()
        {

        }
    }
}
