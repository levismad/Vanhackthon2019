using FillerPDF.Contracts;
using System;
using System.Collections.Generic;

namespace FillerPDF.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class RadioFieldAttribute : PdfFillerAttribute, IFieldAttribute
    {
        KeyValuePair<string, object> _field;
        readonly string _returnValue;
        public RadioFieldAttribute(string propName, object value)
        {
            _field = new KeyValuePair<string, object>(propName, value);
            _returnValue = "Yes";
        }
        public RadioFieldAttribute(string propName, object value, string returnValue)
        {
            _field = new KeyValuePair<string, object>(propName, value);
            _returnValue = returnValue;
        }
        public override Dictionary<string, string> GetValues(object propValue)
        {
            return propValue.Equals(_field.Value) ? new Dictionary<string, string>() { { _field.Key, _returnValue } } : null;
        }
    }
}
