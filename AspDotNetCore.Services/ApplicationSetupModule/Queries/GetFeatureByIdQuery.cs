using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Queries
{
    public record GetFeatureByIdQuery(int FeatureId) : IRequest<FeatureModel>;
    
}
