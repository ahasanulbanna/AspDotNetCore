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
    public class GetModuleByIdHandler : IRequestHandler<GetModuleByIdQuery, ModuleModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetModuleByIdHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ModuleModel> Handle(GetModuleByIdQuery request, CancellationToken cancellationToken)
        {
            var module = await _db.Modules.Where(x=>x.ModuleId==request.ModuleId).SingleOrDefaultAsync();
            var model = _mapper.Map<Module, ModuleModel>(module);
            return model;
        }
    }
}
