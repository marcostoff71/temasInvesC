using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EscritorTexto escri = new EscritorTexto();
            escri.AddText("hola");

            escri.TextCambia += (sender, ar) =>
            {
                if (ar.TextoAna.Contains("o"))
                {
                    ar.CalcelAdd = true;
                }
            };
            escri.AddText(" popo");
            escri.AddText(" lucer");




            Console.WriteLine("El texto actual es: {0}",escri.Texto);
        }
    }
}
