using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.GeneralInfoModule.Model.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public virtual EmployeeDetailsViewModel EmployeeDetails { get; set; }
    }
}
