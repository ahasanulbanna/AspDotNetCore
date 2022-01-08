using System.Collections.Generic;
using System.Threading.Tasks;
using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;
using AspDotNetCore.Services.ApplicationSetupModule.Commands;
using AspDotNetCore.Services.ApplicationSetupModule.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public SubFeaturesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        // GET: api/<SubFeaturesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetSubFeatureById/{SubFeatureId}")]
        public async Task<IActionResult> GetSubFeatureById(int SubFeatureId)
        {
            var query = new GetSubFeatureByIdQuery(SubFeatureId);
            SubFeatureModel model = await _mediatR.Send(new GetSubFeatureByIdQuery(SubFeatureId));
            return Ok(model);
        }

        [HttpPost]
        [Route("AddSubFeature")]
        public async Task<SubFeatureModel> AddSubFeature([FromBody] SubFeatureModel model)
        {
            return await _mediatR.Send(new AddSubFeatureCommand(model));
        }

        // PUT api/<SubFeaturesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubFeaturesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
