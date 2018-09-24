using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewSolution.Models
{
    public class TiffDocument:ImageDocument
    {
        /*
        No need to implement display() cause the
        data would be passed to the view and not the console.
       */
        public override string Display()
        {
            return base.Display();
        }


    }
}