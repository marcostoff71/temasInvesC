using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System.IO;
namespace _061_CombinarPdfs
{
    public partial class Form1 : Form
    {
        string ruta1;
        string ruta2;
        public Form1()
        {
            InitializeComponent();
        }
        public void UniPdf(string rutapdf1, string rutapd2)
        {
            
            PdfReader re1 = new PdfReader(rutapdf1);
            PdfReader re2 = new PdfReader(rutapd2);

            string rutaFin = Path.Combine(Path.GetDirectoryName(ruta1), "marge.pdf");
            PdfDocument a1 = new PdfDocument(re1,new PdfWriter(rutaFin));
            PdfDocument a2 = new PdfDocument(re2);

            PdfMerger merge = new PdfMerger(a1);
            merge.Merge(a2, 1, a2.GetNumberOfPages());

            MessageBox.Show(rutaFin);

            a2.Close();
            a1.Close();

        }

        private void btnSelecionaPdf1_Click(object sender, EventArgs e)
        {
            ruta1 = SelecionaPdf();
            textBox1.Text = ruta1;
        }

        private string SelecionaPdf()
        {
            string ruta = "";

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            open.Filter = "Archivos pdf(*.pdf)|*.pdf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = open.FileName;
            }


            return ruta;
        }

        private void btnSelecionaPdf2_Click(object sender, EventArgs e)
        {
            ruta2 = SelecionaPdf();
            textBox2.Text = ruta2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ruta1 != string.Empty && ruta2 != string.Empty)
            {
                UniPdf(ruta1, ruta2);
            }
        }
    }
}
