using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.EmployeeModule
{
    public class GetEmployees : IGetEmployees
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetEmployees(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var employees = await _db.Employees.ToListAsync();

            var employeesModel = _mapper.Map<List<Employee>, List<EmployeeModel>>(employees);
            return employeesModel;
        }
    }
}
