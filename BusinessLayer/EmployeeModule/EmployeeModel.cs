using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace BusinessLayer.EmployeeModule
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public static explicit operator EmployeeModel(List<Employee> v)
        {
            throw new NotImplementedException();
        }
    }
}
