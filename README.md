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

The POC project creates a populated version of the PDF document (ESDC-EMP5624) and than opens it

```
FillerPDF.POC.exe
```

### Acknowledgments

* The core of the PDF configuration uses [itext7](https://github.com/itext/itext7)