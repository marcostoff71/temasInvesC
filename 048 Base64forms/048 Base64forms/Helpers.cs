using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace _048_Base64forms
{
    public class Helpers
    {
        public static Image ImageFromBas64(string base64)
        {
            byte[] img=Convert.FromBase64String(base64);

            Image bmp = null;
            
            using(MemoryStream ms = new MemoryStream())
            {
                ms.Read(img, 0, img.Length);
                ms.Seek(0, SeekOrigin.Begin);
                bmp = Bitmap.FromStream(ms);
            }


            return bmp;
           
        }
        public static string Base64FromImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
           // System.Drawing.Imaging.ImageFormat=img.
            img.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            
            
            byte[] base64 =ms.ToArray();
            ms.Close();
            
            return Convert.ToBase64String(base64);
        }
    }
}
