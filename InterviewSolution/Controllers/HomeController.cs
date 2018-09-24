using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewSolution.Models;
using InterviewSolution.Models.Display;

namespace InterviewSolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyDocumentProvider document = new MyDocumentProvider();

            List<DisplayAllDocument> allDocument = new List <DisplayAllDocument>();
          
            //instants of the children from the GetDocument
            IEnumerable<Document> plainList = document.GetDocuments("Plain Document");

            IEnumerable<Document> pdfList = document.GetDocuments("PDF Document");

            IEnumerable<Document> tiffList = document.GetDocuments("Tiff Document");

           

        
            //filling the display model with the information from the children
            foreach (PdfDocument each in pdfList)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;
                temp.PixelType = each.PixelType.ToString();
                temp.FrameCount = each.FrameCount.ToString();
                temp.PdfVersion = each.PdfVersion.ToString();
               


                
                allDocument.Add(temp);
            }

            //filling the display model with the information from the children
            foreach (TiffDocument each in tiffList)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;
                temp.PixelType = each.PixelType.ToString();
                temp.FrameCount = each.FrameCount.ToString();
              




                allDocument.Add(temp);
            }
            //filling the display model with the information from the children
            foreach (PlainTextDocument each in plainList)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;

             
                temp.Text = each.Text;

                allDocument.Add(temp);
            }

            //passing all the information from display to view
            ViewBag.Table1 = allDocument;

            //passing all the information from display to view where size > 200
            ViewBag.Table2 = allDocument.Where(x => x.Size > 200).ToList();

            //passing all the information from display to view where size > 200 and its  pdf
            ViewBag.Table3 = allDocument.Where(x => x.Size > 200 && Convert.ToInt32(x.PdfVersion) > 0).ToList();

            //passing all the information from display to view where pixelType is color
            ViewBag.Table4 = allDocument.Where(x => x.PixelType == PixelType.Color.ToString()).ToList();

            //passing all the information from display to view where pdf is 2
            ViewBag.Table5 = allDocument.Where(x => Convert.ToInt32(x.PdfVersion) == 2).ToList();

            ViewBag.Table6 = from element in allDocument orderby element.Size select element;

            return View();
        }

        

    }
}