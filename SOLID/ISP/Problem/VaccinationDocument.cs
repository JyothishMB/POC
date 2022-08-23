using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Problem.Interfaces;

namespace ISP.Problem
{
    public class VaccinationDocument : IDocument
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
            Console.WriteLine("Vaccination Certificate attached");
        }

        public void CheckDocumentValidity()
        {
            throw new NotImplementedException();
        }

        public void GenerateBarcodeForDocument()
        {
            throw new NotImplementedException();
        }

    }
}