using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Problem.Interfaces;
using ISP.Solution.Interfaces;

namespace ISP.Solution
{
    public class SomeConfidentialDocument : IBaseDocument , IDocumentBarcode, IValidity
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