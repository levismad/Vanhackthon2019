using iText.Kernel.Pdf;
using FillerPDF.Models;
using System.Collections.Generic;

namespace FillerPDF.Contracts
{
    public interface IFiller
    {
        void Fill(PdfDocument pdfDocument);
        IEnumerable<string> GetFields(PdfDocument pdfDocument);
        IEnumerable<DocumentFieldDefinition> GetPropertyOrFields(object parent = null, string parentName = null);
    }
}
