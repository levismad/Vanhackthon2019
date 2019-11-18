using FillerPDF.Contracts;
using System;
using System.Collections.Generic;

namespace FillerPDF.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class CheckboxFieldAttribute : PdfFillerAttribute, IFieldAttribute
    {
        readonly KeyValuePair<string, object> _field;
        readonly string _returnValue;
        public CheckboxFieldAttribute(string propName, object value)
        {
            _field = new KeyValuePair<string, object>(propName, value);
            _returnValue = "Yes";
        }
        public CheckboxFieldAttribute(string propName, object value, string returnValue)
        {
            _field = new KeyValuePair<string, object>(propName, value);
            _returnValue = returnValue;
        }
        public override Dictionary<string, string> GetValues(object propValue)
        {
            if (propValue is Array)
            {
                var result = new Dictionary<string, string>();
                var arr = propValue as Array;
                var enumarator = arr.GetEnumerator();
                while (enumarator.MoveNext())
                {
                    if (enumarator.Current.Equals(_field.Value))
                        result.Add(_field.Key, _returnValue);
                }
                return result;
            }
            else
                return propValue.Equals(_field.Value) ? new Dictionary<string, string>() { { _field.Key, "Yes" } } : null;
        }
    }
}
