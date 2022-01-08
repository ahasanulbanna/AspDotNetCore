using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using AspDotNetCore.Services.ApplicationSetupModule.Queries;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Services.ApplicationSetupModule.Handlers
{
    public class GetSubFeatureByIdHandler : IRequestHandler<GetSubFeatureByIdQuery, SubFeatureModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetSubFeatureByIdHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<SubFeatureModel> Handle(GetSubFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var module = await _db.SubFeatures.Where(x => x.FeatureId == request.SubFeatureId).SingleOrDefaultAsync();
            var model = _mapper.Map<SubFeature, SubFeatureModel>(module);
            return model;
        }
    }
}
