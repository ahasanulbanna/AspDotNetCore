using System.Threading;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using AspDotNetCore.Services.ApplicationSetupModule.Commands;
using AutoMapper;
using MediatR;

namespace AspDotNetCore.Services.ApplicationSetupModule.Handlers
{
    public class AddFeatureHandler:IRequestHandler<AddFeatureCommand, FeatureModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public AddFeatureHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<FeatureModel> Handle(AddFeatureCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<FeatureModel, Feature>(request.feature);
            await _db.AddAsync(model);
            await _db.SaveChangesAsync();
            var featureModel = _mapper.Map<Feature, FeatureModel>(model);
            return featureModel;
        }
    }
}
