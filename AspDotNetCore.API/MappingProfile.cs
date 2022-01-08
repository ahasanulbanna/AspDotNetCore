using AspDotNetCore.Services.DTOModel.BusinessModel;
using AutoMapper;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.DTOModel.ViewModel;
using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using AspDotNetCore.Services.ApplicationSetupModule.ViewModel;

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
            CreateMap<Module, ModuleModel>();
            CreateMap<Feature, FeatureModel>();
            CreateMap<SubFeature, SubFeatureModel>();
            CreateMap<Module, ModuleFeatureSubFeatureOperationViewModel>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<SubFeature, SubFeatureViewModel>();

            //***********Business Model To Data Model ****************
            CreateMap<EmployeeModel, Employee>();
            CreateMap<EmployeeDetailsModel, EmployeeDetails>();
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<ModuleModel, Module>();
            CreateMap<FeatureModel, Feature>();
            CreateMap<SubFeatureModel, SubFeature>();

            CreateMap<ModuleFeatureSubFeatureOperationViewModel, Module>();
            CreateMap<FeatureViewModel, Feature>();
            CreateMap<SubFeatureViewModel, SubFeature>();

        }
    }
}
