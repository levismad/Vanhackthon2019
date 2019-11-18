using iText.Forms.Fields;
using System.Collections.Generic;

namespace FillerPDF.Extensions
{
    public static class PdfFillerExtensions
    {
        public static void SetField(this IDictionary<string, PdfFormField> fields, string fieldName, string value)
        {
            if (fields.TryGetValue(fieldName, out PdfFormField toSet))
                toSet.SetValue(value);
        }
    }
}
