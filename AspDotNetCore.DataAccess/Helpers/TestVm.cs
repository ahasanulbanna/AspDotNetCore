using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCore.DataAccess.Helpers
{
    public class TestVm : IgnorableEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        //public string Designation { get; set; }
    }
}
