using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace InterviewSolution.Models
{
    public class MyDocumentProvider:IDocumentProvider
    {
        


        public IEnumerable<Document> GetDocuments(string Instruction)
        {

            
           
            List<PdfDocument> pdfObj = new List<PdfDocument>();
            List<TiffDocument> tiffObj = new List<TiffDocument>();
            List<PlainTextDocument> plainObj = new List<PlainTextDocument>();
 

            TiffDocument tiff = new TiffDocument();
            tiff.Name = "Tiff2";
            tiff.Size = 200;
            tiff.PixelType = PixelType.BlackAndWhite;
            tiff.FrameCount = 20;

            TiffDocument tiff2 = new TiffDocument();
            tiff2.Name = "Tiff1";
            tiff2.Size = 100;
            tiff2.PixelType = PixelType.Color;
            tiff2.FrameCount = 10;

            PdfDocument pdf = new PdfDocument();
            pdf.Name = "Application1";
            pdf.Size = 9000;
            pdf.PixelType = PixelType.BlackAndWhite;
            pdf.FrameCount = 200;
            pdf.PdfVersion = 2;

            PdfDocument pdf2 = new PdfDocument();
            pdf2.Name = "Application2";
            pdf2.Size = 3000;
            pdf2.PixelType = PixelType.Color;
            pdf2.FrameCount = 100;
            pdf2.PdfVersion = 1;

            PlainTextDocument PlainText1 = new PlainTextDocument();
            PlainText1.Name = "Text ABC";
            PlainText1.Size = 400;
            PlainText1.Text = "abcdefg";

            PlainTextDocument PlainText2 = new PlainTextDocument();
            PlainText2.Name = "Text 123";
            PlainText2.Size = 12;
            PlainText2.Text = "123456789";

  


            pdfObj.Add(pdf);
            pdfObj.Add(pdf2);

            tiffObj.Add(tiff);
            tiffObj.Add(tiff2);

           

            plainObj.Add(PlainText1);
            plainObj.Add(PlainText2);

          




            IEnumerable<Document> PdfDocumentData = (IEnumerable<PdfDocument>)(pdfObj);
            IEnumerable<Document> PlainTextDocumentData = (IEnumerable<PlainTextDocument>)(plainObj);
            IEnumerable<Document> TiffDocumentData= (IEnumerable<TiffDocument>)(tiffObj);


           

            if (Instruction == "Plain Document"){

                return PlainTextDocumentData;

            }else if(Instruction ==  "PDF Document"){

                return PdfDocumentData;

            }else if (Instruction == "Tiff Document")
            {
                return TiffDocumentData;
            }


            return TiffDocumentData;
        }

     
    }
}