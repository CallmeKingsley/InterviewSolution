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
          
            IEnumerable<Document> test = document.GetDocuments("All Document");

            IEnumerable<Document> test2 = document.GetDocuments("PDF Document");

            IEnumerable<Document> test3 = document.GetDocuments("Color Document");

            PlainTextDocument kings = new PlainTextDocument();

        
          
            foreach (PdfDocument each in test2)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;
                temp.PixelType = each.PixelType.ToString();
                temp.FrameCount = each.FrameCount;
                temp.PdfVersion = each.PdfVersion;
                temp.Text = "Non Applicable";


                
                allDocument.Add(temp);
            }

            foreach (TiffDocument each in test3)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;
                temp.PixelType = each.PixelType.ToString();
                temp.FrameCount = each.FrameCount;
                temp.PdfVersion = 0;
                temp.Text = "Non Applicable";




                allDocument.Add(temp);
            }
            foreach (PlainTextDocument each in test)
            {
                DisplayAllDocument temp = new DisplayAllDocument();

                temp.Name = each.Name;
                temp.Size = each.Size;
                temp.PixelType = "None Assign";
                temp.FrameCount = 0;
                temp.PdfVersion = 0;
                temp.Text = each.Text;

                allDocument.Add(temp);
            }

            ViewBag.Table1 = allDocument;
            ViewBag.Table2 = allDocument.Where(x => x.Size > 200).ToList();
            ViewBag.Table3 = allDocument.Where(x => x.Size > 200 && x.PdfVersion > 0).ToList();
            ViewBag.Table4 = allDocument.Where(x => x.PixelType == PixelType.Color.ToString()).ToList();
            ViewBag.Table5 = allDocument.Where(x => x.PdfVersion == 2).ToList();
            ViewBag.Table6 = from element in allDocument orderby element.Size select element;
            return View();
        }

        

    }
}