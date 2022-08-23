using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Problem.Interfaces;

namespace ISP.Problem
{
    public class SomeConfidentialDocument : IDocument
    {
        public void AddDocument()
        {
            Console.WriteLine("Document added");
        }
        public void RemoveDocument()
        {
            Console.WriteLine("Document removed");
        }
        public void UpdateDocument()
        {
            Console.WriteLine("Document updated");
        }

        public void AttachFilesToDocument()
        {
            throw new NotImplementedException();
        }

        public void GenerateBarcodeForDocument()
        {
            Console.WriteLine("Document Barcode generated");
        }

        public void CheckDocumentValidity()
        {
            Console.WriteLine("Document is valid");
        }
    }
}