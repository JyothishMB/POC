using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Solution
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}