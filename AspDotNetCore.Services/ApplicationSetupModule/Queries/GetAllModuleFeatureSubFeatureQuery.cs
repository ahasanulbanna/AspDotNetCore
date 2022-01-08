using System.Collections.Generic;
using AspDotNetCore.Services.ApplicationSetupModule.ViewModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Queries
{
    public class GetAllModuleFeatureSubFeatureQuery : IRequest<List<ModuleFeatureSubFeatureOperationViewModel>>
    {
    }
}
