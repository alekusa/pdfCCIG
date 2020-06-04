using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;

namespace EditPdf
{
    public class Extractor
    {
        public void ExtractAttachments()
        {
        }

        internal void ExtractAttachments(string file_name, string folderName, PdfWriter write)
        {
            PdfDictionary documentNames = null;
            PdfDictionary embeddedFiles = null;
            PdfDictionary fileArray = null;
            PdfDictionary file = null;
            PRStream stream = null;

            PdfReader reader = new PdfReader(file_name);
            PdfDictionary catalog = reader.Catalog;

            documentNames = (PdfDictionary)PdfReader.GetPdfObject(catalog.Get(PdfName.NAMES));

            if (documentNames != null)
            {
                embeddedFiles = (PdfDictionary)PdfReader.GetPdfObject(documentNames.Get(PdfName.EMBEDDEDFILES));
                if (embeddedFiles != null)
                {
                    PdfArray filespecs = embeddedFiles.GetAsArray(PdfName.NAMES);

                    for (int i = 0; i < filespecs.Size; i++)
                    {
                        i++;
                        fileArray = filespecs.GetAsDict(i);
                        file = fileArray.GetAsDict(PdfName.EF);

                        foreach (PdfName key in file.Keys)
                        {
                            stream = (PRStream)PdfReader.GetPdfObject(file.GetAsIndirectObject(key));
                            string attachedFileName = folderName + fileArray.GetAsString(key).ToString();
                            byte[] attachedFileBytes = PdfReader.GetStreamBytes(stream);
                            //graba el anexo extraido
                            System.IO.File.WriteAllBytes(attachedFileName, attachedFileBytes);
                            //adjunta los anexos
                            PdfFileSpecification pfs = PdfFileSpecification.FileEmbedded(write, attachedFileName, fileArray.GetAsString(key).ToString(), null);
                            write.AddFileAttachment(pfs);
                            //borramos los archivos extraidos
                            System.IO.File.Delete(attachedFileName);
                        }

                    }
                }
            }
        }
    }
}
