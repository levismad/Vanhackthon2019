using System.Collections.Generic;
using FillerPDF.Contracts;

namespace FillerPDF.Attributes
{
    public class SimpleTextFieldAttribute : PdfFillerAttribute, IFieldAttribute
    {
        public SimpleTextFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
        public string FieldName { get; set; }

        public override Dictionary<string, string> GetValues(object propValue)
        {
            if (propValue == null) return null;
            var result = new Dictionary<string, string>();
            result.Add(FieldName, propValue.ToString());
            return result;
        }
    }
}
