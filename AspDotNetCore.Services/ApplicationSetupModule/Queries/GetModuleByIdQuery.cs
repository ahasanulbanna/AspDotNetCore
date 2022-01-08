using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Queries
{
    public record GetModuleByIdQuery(int ModuleId) : IRequest<ModuleModel>;
}
