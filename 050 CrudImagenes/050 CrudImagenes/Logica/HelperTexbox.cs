using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _050_CrudImagenes.Logica
{
    public static class HelperTexbox
    {
        public static void QuitaEspacios(this TextBox text)
        {
            text.Text = text.Text.Trim();
        }
    }
}
