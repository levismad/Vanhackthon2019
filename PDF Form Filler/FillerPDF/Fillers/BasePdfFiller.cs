using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using FillerPDF.Contracts;
using FillerPDF.Enums;
using FillerPDF.Extensions;
using FillerPDF.Models;
using System.Collections.Generic;
using System.Linq;
using FillerPDF.Attributes;

namespace FillerPDF.Fillers
{
    public class BasePdfFiller<T> : IFiller
    {
        protected T _model;
        /// <summary>
        /// Default pdf filler, it knows how to fill a pdf document based on a instance of a model of type T 
        /// </summary>
        /// <param name="model">Model that contains all of the definition and its values</param>
        public BasePdfFiller(T model)
        {
            _model = model;
        }
        /// <summary>
        /// Fills the  pdf document with the properties of the loaded model
        /// </summary>
        /// <param name="pdfDocument">Output pdf document</param>
        public virtual void Fill(PdfDocument pdfDocument)
        {
            // get the form inside the pdf
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDocument, true);
            // get all fields from the form
            IDictionary<string, PdfFormField> fields = form.GetFormFields();

            // gets the model properties/fields definition
            var modelDefinitions = GetPropertyOrFields();
            foreach (var definition in modelDefinitions)
            {
                var value = definition.GetValue(_model);
                // if no value was inferred based on definition, skip definition
                if (!((value?.Count ?? 0) > 0)) continue;
                foreach (var b in value)
                {
                    fields.SetField(b.Key, b.Value.ToString());
                }
            }

            // Only add the fields that were setten
            form.FlattenFields();
            // Closes and saves the pdf
            pdfDocument.Close();
        }
        /// <summary>
        /// Returns a list of the each form field name
        /// </summary>
        /// <param name="pdfDocument">Input pdf document</param>
        /// <returns>Returns a list of the each form field name</returns>
        public virtual IEnumerable<string> GetFields(PdfDocument pdfDocument)
        {
            // get the form inside the pdf
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDocument, true);
            // get all the fields
            var fields = form.GetFormFields();
            // return only the names
            return fields.Select(x => x.Key);
        }
        /// <summary>
        /// Gets all the fields definition of the loaded model
        /// </summary>
        /// <param name="currentInstanceProp">for recursion purpose, if the value is null the reference is the model itself</param>
        /// <param name="currentInstancePropName">for recursion purpose, if the value is null the reference is the model itself</param>
        /// <returns>Returns a list of fields definition of the loaded model</returns>
        public virtual IEnumerable<DocumentFieldDefinition> GetPropertyOrFields(object currentInstanceProp = null, string currentInstancePropName = null)
        {
            // for recursion purpose, if the value is null the reference is the model itself
            if (currentInstanceProp == null)
                currentInstanceProp = _model;

            var fields = new List<DocumentFieldDefinition>();

            // iterates on all model properties
            foreach (var p in currentInstanceProp.GetType().GetProperties())
            {
                var customAttributes = (IFieldAttribute[])p.GetCustomAttributes(typeof(PdfFillerAttribute), true);
                var propName = string.Join(".", new string[] { currentInstancePropName, p.Name }.Where(x => !string.IsNullOrEmpty(x)));
                // ClassWithFields properties itself doesn't contains definitions but its properties/fields have
                if (customAttributes.Any(x => x.GetType() == typeof(ClassWithFieldsDefinitionAttribute)))
                {
                    var obj = currentInstanceProp.GetType().GetProperty(p.Name).GetValue(currentInstanceProp);
                    if (obj == null) continue;

                    fields.AddRange(GetPropertyOrFields(obj, propName));
                }
                else if ((customAttributes?.Length ?? 0) > 0)
                    fields.Add(new DocumentFieldDefinition(propName,
                                                 FieldType.Property,
                                                 customAttributes));
            }
            // iterates on all model fields
            foreach (var p in currentInstanceProp.GetType().GetFields())
            {
                var customAttributes = (IFieldAttribute[])p.GetCustomAttributes(typeof(PdfFillerAttribute), true);
                var propName = string.Join(".", new string[] { currentInstancePropName, p.Name }.Where(x => !string.IsNullOrEmpty(x)));
                // ClassWithFields fields itself doesn't contains definitions but its properties/fields have
                if (customAttributes.Any(x => x.GetType() == typeof(ClassWithFieldsDefinitionAttribute)))
                {
                    var obj = currentInstanceProp.GetType().GetField(p.Name).GetValue(currentInstanceProp);
                    if (obj == null) continue;

                    fields.AddRange(GetPropertyOrFields(obj, propName));
                }
                else if ((customAttributes?.Length ?? 0) > 0)
                    fields.Add(new DocumentFieldDefinition(propName,
                                                 FieldType.Field,
                                                 customAttributes));

            }
            return fields;
        }
    }
}
