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
    public class AddSubFeatureHandler : IRequestHandler<AddSubFeatureCommand, SubFeatureModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public AddSubFeatureHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<SubFeatureModel> Handle(AddSubFeatureCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<SubFeatureModel, SubFeature>(request.subFeature);
            await _db.AddAsync(model);
            await _db.SaveChangesAsync();
            var subFeatureModel = _mapper.Map<SubFeature, SubFeatureModel>(model);
            return subFeatureModel;
        }
    }
}


