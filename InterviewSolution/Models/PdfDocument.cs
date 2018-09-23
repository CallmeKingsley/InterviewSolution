using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewSolution.Models
{
    public class PdfDocument:ImageDocument
    {
        public int PdfVersion { get; set; }

        public override string Display()
        {


            return base.Display();
        }
    }
}