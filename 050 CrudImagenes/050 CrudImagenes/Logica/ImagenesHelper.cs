using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _050_CrudImagenes.Logica
{
    public class ImagenesHelper
    {
        public static Image ObtieneImagenDeRuta(string ruta)
        {
            Image img = null;
            if (!File.Exists(ruta)) {
                Console.WriteLine("La ruta actual no existe");
                return null;
                    }

            byte[] arrBytes = File.ReadAllBytes(ruta);
            MemoryStream ms = new MemoryStream(arrBytes);


            

            img = Image.FromStream(ms);
            ms.Close();


            return img;
            

           
        }
        public static byte[] ObtieneBytesDeImagen(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                


                return ms.ToArray();
            }
        }
        public static byte[] ObtieneBytesDeRuta(string ruta)
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllBytes(ruta);

            }
            else
            {
                return null;
            }
        }
        public static Image ObtieneImagenDeBytes(byte[] arr)
        {
            Image img;
            MemoryStream ms = new MemoryStream(arr);

            img = Image.FromStream(ms);
            ms.Close();


            return img;
        }
    }
}
