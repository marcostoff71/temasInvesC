using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_GeneraCodigos
{
    class Program
    {
        static void Main(string[] args)
        {
            LCodigos generaCodigos = new LCodigos();
            List<Producto> productos = new List<Producto>();
            

            string nombre;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Ingresa el nombre del producto {0}: ",i+1);
                nombre = Console.ReadLine();
                Producto producto = new Producto();
                producto.Codigo = generaCodigos.ObtieneCodigoUnico(productos.Select(e => e.Codigo));
                producto.Nombre = nombre;
                productos.Add(producto);
            }

            foreach (var item in productos)
            {
                Console.WriteLine("Nombre {0} Codigo {1}",item.Nombre,item.Codigo);
            }

        }
    }
}
