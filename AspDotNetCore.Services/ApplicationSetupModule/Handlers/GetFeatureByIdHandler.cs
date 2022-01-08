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
    public class GetFeatureByIdHandler : IRequestHandler<GetFeatureByIdQuery, FeatureModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetFeatureByIdHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<FeatureModel> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var module = await _db.Features.Where(x => x.FeatureId == request.FeatureId).SingleOrDefaultAsync();
            var model = _mapper.Map<Feature, FeatureModel>(module);
            return model;
        }
    }
}
