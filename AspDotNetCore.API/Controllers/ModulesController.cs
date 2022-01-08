using System.Collections.Generic;
using System.Threading.Tasks;
using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using AspDotNetCore.Services.ApplicationSetupModule.Commands;
using AspDotNetCore.Services.ApplicationSetupModule.Queries;
using AspDotNetCore.Services.ApplicationSetupModule.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public ModulesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        [HttpGet]
        [Route("GetAllModuleFeatureSubFeature")]
        public async Task<IActionResult> GetAllModuleFeatureSubFeature()
        {
            var query = new GetAllModuleFeatureSubFeatureQuery();

            List<ModuleFeatureSubFeatureOperationViewModel> models = await _mediatR.Send(query);
            //List<EmployeeViewModel> models = await _employeeService.GetAllEmployees();
            return Ok(models);
        }

        // GET api/<ModulesController>/5
        [HttpGet("GetModuleById/{ModuleId}")]
        public async Task<IActionResult> GetModuleById(int ModuleId)
        {
            var query = new GetModuleByIdQuery(ModuleId);

            ModuleModel model = await _mediatR.Send(query);
            return Ok(model);
        }

        [HttpPost]
        [Route("AddModule")]
        public async Task<ModuleModel> AddModule([FromBody] ModuleModel model)
        {
            return await _mediatR.Send(new AddModuleCommand(model));
        }

        // PUT api/<ModulesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModulesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
