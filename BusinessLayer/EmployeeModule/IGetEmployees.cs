using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EmployeeModule
{
    public interface IGetEmployees
    {
        Task<List<EmployeeModel>> GetAllEmployees();
    }
}
