using iText.IO.Font.Constants;
using iText.Kernel.Font;
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

                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, "windows-1254");
                Paragraph paragraph = new Paragraph("ÜĞŞİÖÇ\nUGSIOC")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetMarginTop(115)
                    .SetMarginLeft(35)
                    .SetFontSize(10)
                    .SetWidth(200)
                    .SetFont(font);

                document.Add(paragraph);
                document.Close();
            }

        }
    }
}