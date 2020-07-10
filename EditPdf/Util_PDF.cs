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
    class Util_PDF
    {

        public String Add(string archivoFinal, string archivo, String NumeroDeControl, String OP)
        {
            string Error = "";
            try
            {
                //instanciamos la clase para manejar fechas y horas
                DateTime d = DateTime.Now;
                //Formato Grupo Fecha Hora militar (GFH)
                String mes = d.ToString("MMM");
                mes = mes.Substring(0, mes.Length - 1).ToUpper();
                String dato = "RX: GFH "+ d.ToString("ddHHmm"+mes+"yy");
                

                using (var reader = new PdfReader(archivo))
                {
                    using (var fileStream = new FileStream(archivoFinal, FileMode.Create, FileAccess.Write))
                    {
                        var document = new Document(reader.GetPageSizeWithRotation(1));
                        var writer = PdfWriter.GetInstance(document, fileStream);

                        document.Open();

                        var baseFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD).BaseFont;
                        var importedPage = writer.GetImportedPage(reader, 1);
                        var contentByte = writer.DirectContent;
                        contentByte.BeginText();
                        contentByte.SetFontAndSize(baseFont, 12);
                        contentByte.ShowTextAligned(1, "CCIG \"CÓRDOBA\"", 100, 830, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, OP, 35, 795, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "NC CCIG: " + NumeroDeControl, 35, 810, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dato, 35, 780, 0);
                        contentByte.EndText();
                        contentByte.AddTemplate(importedPage, 0, 0);

                        for (var i = 2; i <= reader.NumberOfPages; i++)
                        {
                            document.NewPage();

                            importedPage = writer.GetImportedPage(reader, i);
                            contentByte.BeginText();
                            contentByte.SetFontAndSize(baseFont, 12);
                            contentByte.ShowTextAligned(1, "CENTRO DE COMUNICACIONES E INFORMÁTICA GUARNICIONAL \"CÓRDOBA\"", 300, 830, 0);
                            contentByte.EndText();
                            contentByte.AddTemplate(importedPage, 0, 0);

                            
                        }
                        

                        //Extraer archivo Adjunto y Agregarlos
                        Extractor extrac = new Extractor();
                        extrac.ExtractAttachments(archivo, archivoFinal, writer);


                        document.Close();
                        writer.Close();
                    }
                }
                
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
            return Error;

            


            
        }


    }
}
