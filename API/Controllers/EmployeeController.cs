using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.EmployeeModule;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ISaveEmployee _saveEmployee;
        private readonly IGetEmployees _getEmployee;
        public EmployeeController(ISaveEmployee saveEmployee, IGetEmployees getEmployee)
        {
            _saveEmployee = saveEmployee;
            _getEmployee = getEmployee;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<EmployeeModel> models =await _getEmployee.GetAllEmployees();
            return Ok(models);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> SaveEmployeeAsync([FromBody] EmployeeModel model)
        {
            return Ok(new
            {
                Result = await _saveEmployee.SaveEmployeeAsync(model)
            });
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
