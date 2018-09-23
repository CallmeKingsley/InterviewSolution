
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewSolution.Models
{

    public abstract class Document
    {

        public string Name { get; set; }

        public int Size { get; set; }

        public abstract string Display();
    }

    public enum PixelType
    {
        Color,
        GrayScale,
        BlackAndWhite
    }

    public interface IDocumentProvider
    {
        IEnumerable<Document> GetDocuments(string Instruction);
    }

}
