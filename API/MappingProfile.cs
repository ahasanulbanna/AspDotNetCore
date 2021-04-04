using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.GeneralInfoModule;
using BusinessLayer.GeneralInfoModule.Model.BusinessModel;
using BusinessLayer.GeneralInfoModule.Model.ViewModel;
using DataLayer.Models;

namespace API
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //***********Data Model To Business Model****************
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeDetails, EmployeeDetailsModel>();
            CreateMap<EmployeeDetails, EmployeeDetailsViewModel>();

            //***********Business Model To Data Model ****************
            CreateMap<EmployeeModel, Employee>();
            CreateMap<EmployeeDetailsModel, EmployeeDetails>();

        }
    }
}
