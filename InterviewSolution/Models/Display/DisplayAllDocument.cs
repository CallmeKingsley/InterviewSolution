using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterviewSolution.Models.Display
{

    /*
     * structure of the display view.
     * 
     */
    public class DisplayAllDocument
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public string PdfVersion { get; set; }

        public string Text { get; set; }

       
        public string PixelType { get; set; }

        public string FrameCount { get; set; }
    }
}