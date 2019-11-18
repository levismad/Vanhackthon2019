# Vanhackthon 2019

## Challanges
### PDF Form Filler
We are trying to automate some of our daily tasks. One of them is filling out immigration PDF forms. We need to be able to fill out a specific PDF form using data from our database.

### Goal
We would like to be able to fill out a PDF form automatically and generate a new version with all its fields filled out.

### Output:
The same PDF with some data filled in

### PDF File
https://catalogue.servicecanada.gc.ca/apps/EForms/pdf/en/ESDC-EMP5624.pdf

### To Test the app

There are 3 ways how to test the app:
* Clone the repo, open the solution file 'Vanhackthon2019/PDF Form Filler/VanHackathon.sln' and run the project 'FillerPDF.POC' 
* Download and run a (Release) [https://github.com/levismad/Vanhackthon2019/releases]
* Visit or demo site
## Example Usage 
First create a document defition class by decorating the class properties/fields with the following supported attributes:
```c#
using FillerPDF.Attributes;
public class PDF_FORM_XPTO
{
    // Radio Fields only accept one input to be selected
    // In this case if the value is 'true' checks the field: "PDF_FORM_XPTO[0].Page1[0].radio_field_name_yes[0]"
    // or if the value is 'false' checks the field: "PDF_FORM_XPTO[0].Page1[0].radio_field_name_no[0]"
    [RadioField("PDF_FORM_XPTO[0].Page1[0].radio_field_name_yes[0]", true)]
    [RadioField("PDF_FORM_XPTO[0].Page1[0].radio_field_name_no[0]", false)]
    public bool SomeRadioField { get; set; }

    // SimpleTextField will put the value of the property into the form field "PDF_FORM_XPTO[0].Page1[0].text_field_name[0]"
    [SimpleTextField("PDF_FORM_XPTO[0].Page1[0].text_field_name[0]")]
    public string SimpleTextField { get; set; }

    // TextFieldFormatted will put the formatted value of the property into the form field "PDF_FORM_XPTO[0].Page1[0].text_field_name[0]"
    // Eg.: DateTextFieldFormatted.ToString("yyyy-MM-dd")
    [TextFieldFormatted("PDF_FORM_XPTO[0].Page4[0].date_formatted_field[0]", typeof(DateTime), "yyyy-MM-dd")]
    public DateTime DateTextFieldFormatted { get; set; }
    
    // Eg.: DecimalTextFieldFormatted.ToString("#.##")
    [TextFieldFormatted("PDF_FORM_XPTO[0].Page4[0].decimal_formatted_field[0]", typeof(decimal), "#.##")]
    public decimal? DecimalTextFieldFormatted { get; set; }


    // Checkbox Fields can accept zero or more values
    // In this case if the array of values contains: 
    // 'Enum1.A' checks the field: "PDF_FORM_XPTO[0].Page1[0].checkBox_field_name_1[0]"
    // 'Enum1.B' checks the field: "PDF_FORM_XPTO[0].Page1[0].checkBox_field_name_2[0]"
    // 'Enum1.C' checks the field: "PDF_FORM_XPTO[0].Page1[0].checkBox_field_name_3[0]"
    // 'Enum1.D' checks the field: "PDF_FORM_XPTO[0].Page1[0].checkBox_field_name_4[0]"
    [CheckboxField("PDF_FORM_XPTO[0].Page5[0].checkBox_field_name_1[0]", Enum1.A)]
    [CheckboxField("PDF_FORM_XPTO[0].Page5[0].checkBox_field_name_2[0]", Enum1.B)]
    [CheckboxField("PDF_FORM_XPTO[0].Page5[0].checkBox_field_name_3[0]", Enum1.C)]
    [CheckboxField("PDF_FORM_XPTO[0].Page5[0].checkBox_field_name_4[0]", Enum1.D)]
    public Enum1[] SomeCheckboxField { get; set; }
    
    // Informs the library to search on this class for more fields definition
    [ClassWithFieldsDefinition]
    public CustomClass Child { get; set; }
}
public class CustomClass {

    [SimpleTextField("PDF_FORM_XPTO[0].Page2[0].text_field_name[0]")]
    public string SimpleTextField { get; set; }
    // ...
}
```


### Acknowledgments

* The core of the PDF configuration uses [itext7](https://github.com/itext/itext7)
