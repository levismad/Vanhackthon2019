using System;
using System.Collections.Generic;

namespace FillerPDF.Attributes
{
    public class TextFieldFormattedAttribute : PdfFillerAttribute
    {
        public TextFieldFormattedAttribute(string fieldName, Type type, string format)
        {
            FieldName = fieldName;
            Format = format;
            Type = type;
        }
        public string FieldName { get; set; }
        public string Format { get; set; }
        public Type Type { get; set; }

        public override Dictionary<string, string> GetValues(object propValue)
        {
            if (propValue == null) return null;
            var result = new Dictionary<string, string>();
            dynamic typedValue = Convert.ChangeType(propValue, Type);
            result.Add(FieldName, typedValue.ToString(Format));
            return result;
        }

    }
}
