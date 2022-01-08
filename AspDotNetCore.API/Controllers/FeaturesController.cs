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
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public FeaturesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        // GET: api/<FeaturesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetFeatureById/{FeatureId}")]
        public async Task<IActionResult> GetFeatureById(int FeatureId)
        {
            var query = new GetFeatureByIdQuery(FeatureId);

            FeatureModel model = await _mediatR.Send(query);
            return Ok(model);
        }

        [HttpPost]
        [Route("AddFeature")]
        public async Task<FeatureModel> AddSubFeature([FromBody] FeatureModel model)
        {
            return await _mediatR.Send(new AddFeatureCommand(model));
        }

        // PUT api/<FeaturesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeaturesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
