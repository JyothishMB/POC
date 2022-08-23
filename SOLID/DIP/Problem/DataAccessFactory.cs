using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Problem
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}