using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EmployeeModule
{
    public interface ISaveEmployee
    {
        Task<EmployeeModel> SaveEmployeeAsync(EmployeeModel model);
    }
}
