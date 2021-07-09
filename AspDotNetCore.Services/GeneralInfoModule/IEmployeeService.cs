using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspDotNetCore.Services.DTOModel.BusinessModel;
using AspDotNetCore.Services.DTOModel.ViewModel;

namespace AspDotNetCore.Services.GeneralInfoModule
{
    public interface IEmployeeService
    {
        Task<EmployeeModel> SaveEmployee(int EmployeeId, EmployeeModel model);
        Task<List<EmployeeViewModel>> GetAllEmployees();
        Task<EmployeeViewModel> GetAllEmployee(int EmployeeId);

    }
}
