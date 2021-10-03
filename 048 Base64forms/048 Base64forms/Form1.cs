using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _048_Base64forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CargaImagen(string ruta)
        {
            if (File.Exists(ruta))
            {
                FileStream fs = new FileStream(ruta,FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);


                fs.Close();

                byte [] imgBites=File.ReadAllBytes(ruta);

                MemoryStream ms = new MemoryStream(imgBites);
                Image img=Image.FromStream(ms);
                ms.Close();

                pictureBox1.Image = img;
            }
        }
        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open.Title = "Abre una imagen";
            //open.Filter = "Archivos de img |*.jpeg";
            if (open.ShowDialog() == DialogResult.OK){
                MessageBox.Show(open.FileName);
                CargaImagen(open.FileName);
            }
        }

        private void btnImageSaveBase64_Click(object sender, EventArgs e)
        {
            if (pictureBox1?.Image != null)
            {
                string base64=Helpers.Base64FromImage(pictureBox1.Image);
                MessageBox.Show(base64);
            }
        }
    }
}
