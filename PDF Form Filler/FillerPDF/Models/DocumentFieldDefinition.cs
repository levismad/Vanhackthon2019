using System;
using FillerPDF.Contracts;
using FillerPDF.Enums;
using System.Collections.Generic;

namespace FillerPDF.Models
{
    public class DocumentFieldDefinition
    {
        public DocumentFieldDefinition(string fieldName, FieldType fieldType, IFieldAttribute[] baseFields)
        {
            FieldName = fieldName;
            FieldType = fieldType;
            BaseFields = baseFields;
        }
        public FieldType FieldType { get; set; }
        public string FieldName { get; set; }
        public IFieldAttribute[] BaseFields { get; set; }
        public Dictionary<string, object> GetValue<T>(T _model)
        {
            var result = new Dictionary<string, object>();

            object mValue = null;
            switch (FieldType)
            {
                case FieldType.Field:
                    mValue = GetFieldValue(_model, FieldName);
                    break;
                case FieldType.Property:
                    mValue = GetPropertyValue(_model, FieldName);
                    break;
            }
            if (mValue == null) return null;

            foreach (var baseField in BaseFields)
            {
                var vls = baseField.GetValues(mValue);
                if (vls == null) continue;
                foreach (var o in vls)
                    result.Add(o.Key, o.Value);
            }
            return result;
        }
        public static object GetFieldValue(object field, string name)
        {
            if (!name.Contains("."))
                return field.GetType().GetField(name).GetValue(field);

            var current = name.Substring(0, name.IndexOf("."));
            name = name.Substring(name.IndexOf(".") + 1);
            field = field.GetType().GetField(current).GetValue(field);
            return GetFieldValue(field, name);

        }
        public static object GetPropertyValue(object field, string name)
        {
            if (!name.Contains("."))
                return field.GetType().GetProperty(name).GetValue(field, null);

            var current = name.Substring(0, name.IndexOf("."));
            name = name.Substring(name.IndexOf(".") + 1);
            field = field.GetType().GetProperty(current).GetValue(field, null);
            return GetPropertyValue(field, name);

        }
    }
}
