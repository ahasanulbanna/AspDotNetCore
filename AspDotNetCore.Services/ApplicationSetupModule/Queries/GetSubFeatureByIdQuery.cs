using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Queries
{
    public record GetSubFeatureByIdQuery(int SubFeatureId) : IRequest<SubFeatureModel>;
    
}
