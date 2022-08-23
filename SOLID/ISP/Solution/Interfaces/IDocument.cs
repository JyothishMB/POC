using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Solution.Interfaces
{
    public interface IBaseDocument
    {
        void AddDocument();
        void RemoveDocument();
        void UpdateDocument();
    }
}