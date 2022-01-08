using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Commands
{
    public record AddFeatureCommand(FeatureModel feature) : IRequest<FeatureModel>;
    
}
