using System.Collections.Generic;
using System.Threading.Tasks;
using AspDotNetCore.Services.DTOModel.BusinessModel;
using AspDotNetCore.Services.DTOModel.ViewModel;
using AspDotNetCore.Services.GeneralInfoModule;
using AspDotNetCore.Services.GeneralInfoModule.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediatR;
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IMediator mediatR, IEmployeeService employeeService )
        {
            _mediatR = mediatR;
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var query = new GetAllEmployeesQuery();

            List<EmployeeViewModel> models = await _mediatR.Send(query);
            //List<EmployeeViewModel> models = await _employeeService.GetAllEmployees();
            return Ok(models);
        }














        [AllowAnonymous]
        [HttpGet("GetAllEmployee/{id}")]
        public string GetAllEmployee(int id)
        {
            return "value";
        }

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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
