using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Commands
{
    public record AddSubFeatureCommand(SubFeatureModel subFeature) : IRequest<SubFeatureModel>;

}
