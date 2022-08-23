using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Problem
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _employeeDataAccess;

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