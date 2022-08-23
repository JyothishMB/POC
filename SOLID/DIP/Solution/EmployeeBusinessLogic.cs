using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Solution.Interfaces;

namespace DIP.Solution
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(Guid employeeid)
        {
            return _employeeDataAccess.GetEmployeeDetails(employeeid);
        }
    }
}