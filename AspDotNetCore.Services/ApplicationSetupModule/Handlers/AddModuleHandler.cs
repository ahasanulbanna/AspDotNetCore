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
    public class AddModuleHandler : IRequestHandler<AddModuleCommand, ModuleModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public AddModuleHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ModuleModel> Handle(AddModuleCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<ModuleModel, Module>(request.module);
            await _db.AddAsync(model);
            await _db.SaveChangesAsync();
            var moduleModel = _mapper.Map<Module, ModuleModel>(model);
            return moduleModel;
        }
    }
}
