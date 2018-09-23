using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace InterviewSolution.Models
{
    public class ImageDocument : Document
    {
      public PixelType PixelType { get; set; }
      public int FrameCount { get; set; }

       public override string Display()
        {
            string james =  "kingsley";


            return james;
        }
    }
}