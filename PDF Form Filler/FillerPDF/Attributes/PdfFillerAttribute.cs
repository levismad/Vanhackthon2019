using FillerPDF.Contracts;
using System;
using System.Collections.Generic;

namespace FillerPDF.Attributes
{
    public class PdfFillerAttribute : Attribute, IFieldAttribute
    {
        public virtual Dictionary<string, string> GetValues(object propValue)
        {
            return null;
        }
    }
}
