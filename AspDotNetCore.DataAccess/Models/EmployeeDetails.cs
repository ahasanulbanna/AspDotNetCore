using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCore.DataAccess.Models
{
    public class EmployeeDetails
    {
        public int EmployeeDetailsId { get; set; }
        public string Address { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
