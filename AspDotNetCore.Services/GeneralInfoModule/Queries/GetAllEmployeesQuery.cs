using System;
using System.Collections.Generic;
using System.Text;
using AspDotNetCore.Services.DTOModel.ViewModel;
using MediatR;

namespace AspDotNetCore.Services.GeneralInfoModule.Queries
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeViewModel>>
    {
    }
}
