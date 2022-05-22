using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using SpreadsheetLight;
using iText.Kernel.Pdf;
using System.IO;
using iText.Layout;
using iText.Layout.Element;
using System.Data;

namespace _072_Leer_excel
{
    public class Nose
    {

        internal Nose()
        {
            Console.WriteLine("hola");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new Nose();


            DataTable dt = new DataTable();

            dt.NewRow();
            dt.Rows.Add(new DataRow("sasa"))

            
            List<Tuple<int, string>> lst = new List<Tuple<int, string>>();



           

            //Nota las filas y columnas se emepizan a contar desde 1

            string path = @"C:\Users\lenovo\Desktop\ex.xlsx";



            int rowActual = 2;

            SpreadsheetLight.SLDocument doc = new SLDocument(path);



            while (!string.IsNullOrEmpty(doc.GetCellValueAsString(rowActual, 1)))
            {
                lst.Add(new Tuple<int, string>(doc.GetCellValueAsInt32(rowActual,1),doc.GetCellValueAsString(rowActual,2)));

                rowActual++;

            }


            lst.ForEach(e =>
            {
                Console.WriteLine($"Edad {e.Item1} Nombre {e.Item2}");
            });





        }
        static void CreaPdf()
        {

            PdfFont pdfFont =PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            using (MemoryStream ms = new MemoryStream())
            {
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(ms));

                Document doc = new Document(pdfDoc);



                doc.Add(new Paragraph("hola"));


                Console.WriteLine("Guardar".PadLeft(10,'-'));
                Console.WriteLine("Ingresa la ruta a guardar");
                string ruta = Console.ReadLine().Trim();
                ruta=$"{ruta}{Path.GetFileNameWithoutExtension(Path.GetRandomFileName())}.pdf";


                Console.WriteLine("\n\nRuta");
                Console.WriteLine(ruta);



                
                using (FileStream fs = new FileStream(ruta, FileMode.Create))
                {
                    PdfDocument doc2 = new PdfDocument(new PdfWriter(fs));

                    pdfDoc.SetCloseWriter(true);
                    
                    pdfDoc.CopyPagesTo(Enumerable.Range(1,pdfDoc.GetNumberOfPages()).ToList(), doc2);

                }

                       




            }
            


        }
    }
}
