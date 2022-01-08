using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.ApplicationSetupModule.Queries;
using AspDotNetCore.Services.ApplicationSetupModule.ViewModel;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Services.ApplicationSetupModule.Handlers
{
    public class GetAllModuleFeatureSubFeatureHandler : IRequestHandler<GetAllModuleFeatureSubFeatureQuery, List<ModuleFeatureSubFeatureOperationViewModel>>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetAllModuleFeatureSubFeatureHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<ModuleFeatureSubFeatureOperationViewModel>> Handle(GetAllModuleFeatureSubFeatureQuery request, CancellationToken cancellationToken)
        {
            var modules = await _db.Modules.Include(x=>x.Features).ThenInclude(x=>x.SubFeatures).ToListAsync();
            var models = _mapper.Map<List<Module>, List<ModuleFeatureSubFeatureOperationViewModel>>(modules);
            return models;
        }
    }
}
