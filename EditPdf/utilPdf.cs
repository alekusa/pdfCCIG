using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace EditPdf
{
    class utilPdf
    {
        public string addTexto(string archivoFinal, string archivo, string texto, Single coorX, Single coorY, Single angulo, int sizeFuente)
        {
            string cErr = "";
            try
            {
                PdfReader reader = new PdfReader(archivo);
                Rectangle size = reader.GetPageSizeWithRotation(1);
                Document document = new Document(size);

                FileStream fs = new FileStream(archivoFinal, FileMode.Create, FileAccess.Write);
                PdfWriter write = PdfWriter.GetInstance(document, fs);
                document.Open();
                PdfContentByte cb = write.DirectContent;
                BaseFont bf;
                bf = FontFactory.GetFont(FontFactory.COURIER, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont;
                cb.SetColorFill(BaseColor.BLUE);
                cb.SetFontAndSize(bf, sizeFuente);
                //escribimos el texto
                cb.BeginText();
                //indicamos donde colocarlo
                cb.ShowTextAligned(1, texto, coorX, coorY, angulo);
                cb.EndText();
                //crea una pagina nueva y la añade al pdf
                PdfImportedPage page = write.GetImportedPage(reader, 1);
                cb.AddTemplate(page, 0, 0);
                //cerrar todo
                document.Close();
                fs.Close();
                write.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                cErr = ex.Message;
            }
            return cErr;
        }
    }
}
