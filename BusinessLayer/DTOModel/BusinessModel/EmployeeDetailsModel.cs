using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOModel.BusinessModel
{
    public class EmployeeDetailsModel
    {
        public int EmployeeDetailsId { get; set; }
        public string Address { get; set; }
        public int EmployeeId { get; set; }
        public virtual EmployeeModel Employees { get; set; }
    }
}
