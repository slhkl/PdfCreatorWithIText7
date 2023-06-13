using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PdfCreateWithIText.Utils
{
    public static class PdfCreator
    {
        public static void CreatePdf(this string filename)
        {
            using (PdfWriter writer = new PdfWriter(filename + ".pdf"))
            {
                PdfDocument pdfDocument = new PdfDocument(writer);
                Document document = new Document(pdfDocument);
                Paragraph header = new Paragraph("Header")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);

                document.Add(header);
                document.Close();
            }
        }
    }
}