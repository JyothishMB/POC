using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Solution.Interfaces;

namespace DIP.Solution
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}