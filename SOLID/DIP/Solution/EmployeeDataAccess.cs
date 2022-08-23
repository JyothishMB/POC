using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Solution.Interfaces;

namespace DIP.Solution
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(Guid employeeid)
        {
            //Logic to get employee from database
            Employee emp = new Employee()
            {
                Id = new Guid(),
                Name = "John Rambo",
                Age = 30,
                Email = "john.rambo@somedomain.com"
            };

            return emp;
        }
    }
}