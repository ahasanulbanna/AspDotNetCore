using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.DTOModel.BusinessModel;
using BusinessLayer.GeneralInfoModule;
using BusinessLayer.GeneralInfoModule.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            List<EmployeeViewModel> models =await _employeeService.GetAllEmployees();
            return Ok(models);
        }

        // GET api/<EmployeeController>/5
        [AllowAnonymous]
        [HttpGet("GetAllEmployee/{id}")]
        public string GetAllEmployee(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("SaveEmployee")]
        public async Task<IActionResult> SaveEmployee([FromBody] EmployeeModel model)
        {
            model = await _employeeService.SaveEmployee(0,model);

            return Ok(new
            {
                Result = model
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
