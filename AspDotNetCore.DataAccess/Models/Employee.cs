using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCore.DataAccess.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public virtual EmployeeDetails EmployeeDetails { get; set; }
    }
}
