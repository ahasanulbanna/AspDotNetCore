using AspDotNetCore.Services.DTOModel.BusinessModel;
using AutoMapper;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.DTOModel.ViewModel;

namespace AspDotNetCore.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //***********Data Model To Business Model****************
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeDetails, EmployeeDetailsModel>();
            CreateMap<EmployeeDetails, EmployeeDetailsViewModel>();
            CreateMap<Customer, CustomerViewModel>();

            //***********Business Model To Data Model ****************
            CreateMap<EmployeeModel, Employee>();
            CreateMap<EmployeeDetailsModel, EmployeeDetails>();
            CreateMap<CustomerViewModel, Customer>();

        }
    }
}
