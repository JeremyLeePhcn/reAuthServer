using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace ReAuthServer.Utils
{
    public class CreatePDF
    {
      
      public virtual void helloPDF(String dest, String name) {

           //Initialize PDF writer
            PdfWriter writer = new PdfWriter(dest);
            //Initialize PDF document
            PdfDocument pdf = new PdfDocument(writer);
            // Initialize document
            Document document = new Document(pdf);
            //Add paragraph to the document
            document.Add(new Paragraph("Hello " + name));
            //Close document
            document.Close();

      }
        
    }
}