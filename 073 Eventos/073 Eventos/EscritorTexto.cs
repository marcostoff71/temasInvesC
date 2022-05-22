using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Eventos
{
    public class EscritorTexto
    {
        private string texto;
        public EscritorTexto()
        {
            this.texto = "";
        }
        public string Texto
        {
            get { return texto; }
        }

        public event EventHandler<EscritorTextoArgs> TextCambia;


        public void AddText(string texto)
        {
            var ev =new EscritorTextoArgs() { TextoAna = texto, TextoCompleto = this.texto,CalcelAdd=false };
            TextCambia?.Invoke(this,ev);

            if (!ev.CalcelAdd)
            {
                this.texto += texto;
            }

        }
    }
    public class EscritorTextoArgs:EventArgs 
    {
        public string TextoAna { get; set; }
        public string TextoCompleto { get; set; }
        public bool CalcelAdd { get; set; }


    }
}
