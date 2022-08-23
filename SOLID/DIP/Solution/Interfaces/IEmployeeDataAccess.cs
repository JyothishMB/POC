using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Solution.Interfaces
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(Guid employeeid);
    }
}