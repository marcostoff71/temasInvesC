using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class CLetras
    {
        Random rdn = new Random();
        public int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
        public void GenadorContra()
        {
            //varibales necesarias
            string albeto = "abcdefghijklmnñopqrstvwxyzABCDEFGHIJKLNÑOPQRSTVWXYZ";
            string contraGene = "";
            int longitud;
            do
            {
                longitud = ValidaInt("Dame la longitud de la contraseña a generar: ");
                
            } while (longitud < 1);
            for (int j = 1; j <= longitud; j++)
            {
                contraGene = contraGene + albeto[rdn.Next(albeto.Length)];
            }

            Console.WriteLine("La contraseña generada es: {0}", contraGene);

        }
        public void ContraGeneCaracteres()
        {
            //varibles necesarias
            string albetoCaracteres = "abcdefghijklmnñopqrstvwxyz1234567890!\"#$%&/()=?¨*[]_-.,";
            string contraGene = "";
            int longitud;
            do
            {
                longitud = ValidaInt("Dame la longitud de la contraseña a generar: ");
            } while (longitud < 1);

            for(int y = 1; y <= longitud; y++)
            {
                contraGene += albetoCaracteres[rdn.Next(albetoCaracteres.Length)];
            }

            Console.WriteLine("La contraseña generada es: {0}",contraGene);
        }
        public void QuitarVocales()
        {
            string textoOriginal = "";
            string vocales = "aeiouáéíóú";
            string textoSinvocales = "";
            do
            {
                Console.Write("Escribe el texto: ");
                textoOriginal = Console.ReadLine();
            } while (textoOriginal.Length < 1);

            textoSinvocales = textoOriginal;
            for(int h = 0; h < vocales.Length; h++)
            {
                textoSinvocales = textoSinvocales.Replace(Convert.ToString(vocales[h]),"");
                textoSinvocales = textoSinvocales.Replace(Convert.ToString(vocales[h]).ToUpper(), "");
            }

            Console.WriteLine("El texto sin vocales es: {0}", textoSinvocales);
        }
        public void Ordenar()
        {
            char[] textoOrdenar ;
            string texto="";
            do
            {
                Console.Write("Escribe el texto a ordenar: ");
                texto = Console.ReadLine();
            } while (texto.Length < 1);

            textoOrdenar = texto.ToCharArray();

            Array.Sort(textoOrdenar);

            texto = new string(textoOrdenar);

            Console.WriteLine("El nuevo texto es: {0}", texto);
        }
        public void Voltear()
        {

        }
    }
}
