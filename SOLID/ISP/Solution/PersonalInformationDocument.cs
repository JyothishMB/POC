using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Solution.Interfaces;

namespace ISP.Solution
{
    public class PersonalInformationDocument : IBaseDocument
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

    }
}