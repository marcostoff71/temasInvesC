using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_Metodos_de_listas_y_lin1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5};
            int[] num = new int[] { 1, 2, 3 }.Concat(new int[] { 1, 2, 3, 4 }).ToArray().Concat<int>(numeros).ToArray();

            List<Persona> lstPersonas = new List<Persona>() { 
            new Persona(){Edad=9,Nombre="marco" },
            new Persona(){Edad=10,Nombre="marco" },
            new Persona(){Edad=11,Nombre="marco" },
            };

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "I");
            dic.Add("2", "II");
            dic.Add("3", "III");
            dic.Add("4", "III");

            ;

            foreach (KeyValuePair<string, string> item in dic)
            {

            }
            List<Producto> lstProductos = new List<Producto>()
            {
                new Producto(){id=1},
                new Producto(){id=2},
                new Producto(){id=3},
                new Producto(){id=4}
            };

            for (int i = 0; i < lstProductos.Count; i++)
            {
                lstProductos[i].GeneraCodigo(lstProductos);
            }
            lstProductos.ForEach(i => Console.WriteLine("Id {0} Codigo {1}",i.id,i.Codigo));



            
            Console.ReadKey();
        }
        
           
    }
    class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
    class Producto
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        private StringGenerator stringGenerator;
        public Producto()
        {
            stringGenerator = new StringGenerator();
        }
        public void GeneraCodigo(IEnumerable<Producto> productos, int lon = 10)
        {
            bool correcto = false;
            string gene;
            do
            {
                gene= this.stringGenerator.GenerarCodigo(lon);
                if (!ExisteCodigo(productos, i => i.Codigo == gene))
                {
                    correcto = true;
                }

            } while (!correcto);
            this.Codigo = gene;
        }
        private bool ExisteCodigo(IEnumerable<Producto> productos,Func<Producto,bool> func)
        {
            foreach (var produco in productos)
            {
                if (func(produco))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class StringGenerator
    {
        public string GenerarCodigo(int lon)
        {
            string dic1 = "ABCDEFGHIJKLMNOPQRSTVWXYZ";
            string dic2 = dic1.ToLower();
            if (lon <= 0)
            {
                throw new ArgumentException("La longitud debe ser mayor a 0");
            }
            string gene = "";
            Random rdn = new Random();
            for (int i = 0; i < lon; i++)
            {
                int pos = rdn.Next((dic1+dic2).Length-1);
                gene += (dic1 + dic2)[pos];
            }
            Desordenar(gene);
            return gene;
        }
        private string Desordenar(string texto)
        {
            char[] textoADes = texto.ToCharArray();

            for (int i = 0; i < textoADes.Length; i++)
            {
                char aux;
                int random = new Random().Next(textoADes.Length - 1);
                aux = textoADes[i];

                textoADes[i] = textoADes[random];
                textoADes[random] = aux;
            }

            return new string(textoADes);
        }
    }
}
