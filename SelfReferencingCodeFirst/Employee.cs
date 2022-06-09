using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfReferencingCodeFirst
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerID { get; set; }
        public Employee Manager { get; set; }

    }
}