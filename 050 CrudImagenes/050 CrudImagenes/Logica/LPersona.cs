using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _050_CrudImagenes.Modelos.AccesoDatos;

namespace _050_CrudImagenes.Logica
{
    public class LPersona
    {
        public string SelecionaNombreUnico(IEnumerable<string> nombres,PersonaRu pPer)
        {
            bool corre = false;
            string gene = "";
            
            while (!corre)
            {
                gene = GeneraNombre(pPer);
                corre = !nombres.Any(e => e == gene);   
            }


            return gene;
            
        }
        private string GeneraNombre(PersonaRu pPer)
        {
            StringBuilder gene = new StringBuilder();


            Random rdn = new Random();
            gene.Append(rdn.Next(100).ToString());
                
            for (int i = 0; i < pPer.Nombre.Length; i++)
            {
                if (char.IsLetterOrDigit(pPer.Nombre[i]))
                {
                    gene.Append(pPer.Nombre[i]);
                }
            }
            for (int i = 0; i < pPer.ApellidoMaterno.Length / 2; i++)
            {
                if (char.IsLetterOrDigit(pPer.ApellidoMaterno[i]))
                {
                    gene.Append(pPer.ApellidoMaterno[i]);
                }
            }

            for (int i = 0; i < pPer.ApellidoPaterno.Length / 2; i++)
            {
                if (char.IsLetterOrDigit(pPer.ApellidoPaterno[i]))
                {
                    gene.Append(pPer.ApellidoPaterno[i]);
                }
            }

            nombre += rdn.Next(1000).ToString();
            nombre=Desorder(nombre);

            return nombre;
        }
        private string Desorder(string texto)
        {
            char[] textoReordenado = texto.ToCharArray();

            Random rdn = new Random();
            char aux;
            int indAle;
            for (int i = 0; i < textoReordenado.Length/2; i++)
            {
                indAle = rdn.Next(textoReordenado.Length - 1);


                aux = textoReordenado[i];
                textoReordenado[i] = textoReordenado[indAle];
                textoReordenado[indAle] = aux;
            }

            return new string(textoReordenado);
        }
        public int CalulaEdad(DateTime fechaNaci)
        {
            return DateTime.Now.Subtract(fechaNaci).Days / 365;
        }
        public List<string> NuevaRuta(List<string> lstRutasOld,string rutanueva)
        {
            List<string> lstRutasNew = new List<string>();
            foreach (var item in lstRutasOld)
            {
                string nombre=Path.GetFileName(item);
                lstRutasNew.Add(Path.Combine(rutanueva, nombre));
            }

            return lstRutasNew;

        }


    }
}
