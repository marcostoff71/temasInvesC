using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Barcodes;
using iText.IO.Font;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using System.Diagnostics;
using iText.Kernel.Pdf.Canvas;
using iText.Layout.Properties;
using iText.IO.Image;

namespace CrearPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto="",aux;
            Console.WriteLine("Ingresa texto a escribir en el pdf doble click para terminar");
            do
            {
                aux = Console.ReadLine();


                texto += aux;
            } while (aux!="");
            PdfFont fon = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLDITALIC);

            Style stylo = new Style();
            stylo.SetFont(fon);
            stylo.SetFontColor(ColorConstants.CYAN);

            PdfWriter pw = new PdfWriter(new System.IO.FileStream("hola.pdf",System.IO.FileMode.Create));

            PdfDocument pDoc = new PdfDocument(pw);

            Document doc = new Document(pDoc,iText.Kernel.Geom.PageSize.LETTER);
            doc.Add(new Paragraph(texto)
                .SetBackgroundColor(ColorConstants.BLUE)
                .SetUnderline()
                .SetPaddingLeft(10)
                .AddStyle(stylo)
                );

            PdfCanvas ca = new PdfCanvas(pDoc,1);
            
            ca.BeginText();

            BarcodeQRCode qr = new BarcodeQRCode();
            qr.SetCode("hola");
            qr.PlaceBarcode(ca, ColorConstants.BLACK).SetHeight(100).SetWidth(100);

            Barcode128 qr128 = new Barcode128(pDoc);
            qr128.SetCode("hola");
            qr128.SetTextAlignment(0);
            qr128.SetFont(PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD));
            qr128.SetSize(12);
            qr128.PlaceBarcode(ca, ColorConstants.BLACK,ColorConstants.BLACK);

            Table table = new Table(10);
            table.AddCell(new Cell().Add(new Paragraph("hola")).SetWidth(20).SetMarginRight(10));
            table.AddCell(new Cell().Add(new Paragraph("hsa")));
            table.AddCell(new Cell().Add(new Paragraph("43434343")));
            table.AddCell(new Cell().Add(new Paragraph("hola")));
            table.AddCell(new Cell().Add(new Paragraph("hola")));
            table.AddCell(new Cell().Add(new Paragraph("hola")));
            table.AddCell(new Cell().Add(new Paragraph("hola")));
            doc.Add(table);

            Image img = new Image(ImageDataFactory.Create(System.IO.File.ReadAllBytes(@"C:\Users\lenovo\Pictures\34.jpg")));

            doc.Add(img);

            doc.Close();
            pw.Close();
            Process.Start(System.IO.Path.Combine(Environment.CurrentDirectory, "hola.pdf"));


        }
    }
}
