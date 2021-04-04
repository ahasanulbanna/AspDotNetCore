using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.GeneralInfoModule.Model.BusinessModel;
using BusinessLayer.GeneralInfoModule.Model.ViewModel;

namespace BusinessLayer.GeneralInfoModule
{
    public interface IEmployeeService
    {
        Task<EmployeeModel> SaveEmployeeAsync(EmployeeModel model);
        Task<List<EmployeeViewModel>> GetAllEmployees();

    }
}
