using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewSolution.Models.Display
{
    public class DisplayAllDocument
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public int PdfVersion { get; set; }

        public string Text { get; set; }

        public string PixelType { get; set; }

        public int FrameCount { get; set; }
    }
}