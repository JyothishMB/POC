using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Problem.Interfaces
{
    public interface IDocument
    {
        void AddDocument();
        void RemoveDocument();
        void UpdateDocument();
        void AttachFilesToDocument();
        void GenerateBarcodeForDocument();
        void CheckDocumentValidity();
    }
}