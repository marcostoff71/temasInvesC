using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_GuardarPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (PdfDocument doc = new PdfDocument(new PdfWriter("aaaaaaaa.pdf")))
            //{
            //    Document dc = new Document(doc);
            //    dc.Add(new Paragraph("hola"));
            //}



            CrearPdf();
            hola();
        }
        static void hola()
        {
            using (MemoryStream baos = new MemoryStream())
            {

                PdfWriter writer = new PdfWriter(baos);
                using (PdfDocument pdfDocument = new PdfDocument(writer.SetSmartMode(true)))
                {

                //writer.SetCloseStream(true);
                //pdfDocument.SetCloseWriter(true);
                //pdfDocument.SetCloseReader(true);
                //pdfDocument.SetFlushUnusedObjects(true);
                    Document d = new Document(pdfDocument, iText.Kernel.Geom.PageSize.LETTER);
                    d.Add(new Paragraph("Hello world!"));
                    d.Close();
                

                
                }
                using (FileStream file = new FileStream("test.pdf",
                     FileMode.Create, FileAccess.Write))
                {

                    file.Write(baos.ToArray(), 0, (int)baos.ToArray().Length);

                }
            }
        }
        static void CrearPdf()
        {

            using (MemoryStream ms = new MemoryStream())
            {
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(ms).SetSmartMode(true));
               
                Document doc = new Document(pdfDoc, iText.Kernel.Geom.PageSize.A0);
                doc.SetMargins(10, 10, 10, 10);
                

                doc.Add(new Paragraph("holasds").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                doc.Add(new Paragraph("holasds").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                doc.Add(new Paragraph("holasds").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                doc.Add(new Paragraph("holasds").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                doc.Add(new Paragraph("holasds").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                
                doc.Close();
                pdfDoc.Close();

                using (FileStream fs = new FileStream("hola.pdf", FileMode.Create))
                {
                    using (PdfDocument docEscribte = new PdfDocument(new PdfWriter("holass.pdf")))
                    {
                        Document d = new Document(docEscribte);
                        d.Add(new Paragraph("hola"));
                        using (MemoryStream msRead = new MemoryStream(ms.ToArray()))
                        {
                            
                            PdfDocument pdfDocGuarda = new PdfDocument(new PdfReader(msRead));

                            pdfDocGuarda.CopyPagesTo(1, pdfDocGuarda.GetNumberOfPages(), docEscribte);

                            Console.WriteLine("Numero de paginas : {0}",pdfDocGuarda.GetNumberOfPages());
                            
                        }
                        d.Close();
                    }

                }
            }

        }
    }
}
