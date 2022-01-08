using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Commands
{
    public record AddModuleCommand(ModuleModel module) : IRequest<ModuleModel>;
  
}
