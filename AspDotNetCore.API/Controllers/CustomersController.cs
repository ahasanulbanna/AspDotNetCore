using System.Collections.Generic;
using System.Threading.Tasks;
using AspDotNetCore.Services.CustomerModule.Commands;
using AspDotNetCore.Services.CustomerModule.Queries;
using AspDotNetCore.Services.DTOModel.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public CustomersController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        [HttpGet]
        [Route("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var query = new GetAllCustomersQuery();
            List<CustomerViewModel> models = await _mediatR.Send(query);
            return Ok(models);
        }
        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        [Route("AddCustomer")]
        public async Task<CustomerViewModel> AddCustomer([FromBody] CustomerViewModel model)
        {
            return await _mediatR.Send(new AddCustomerCommand(model));
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
