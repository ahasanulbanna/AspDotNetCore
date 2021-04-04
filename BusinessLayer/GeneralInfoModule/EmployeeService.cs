using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.GeneralInfoModule.Model.BusinessModel;
using BusinessLayer.GeneralInfoModule.Model.ViewModel;
using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.GeneralInfoModule
{
    public class EmployeeService: IEmployeeService
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public EmployeeService(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<EmployeeModel> SaveEmployeeAsync(EmployeeModel model)
        {
            Employee employee = _mapper.Map<EmployeeModel, Employee>(model);
            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            model= _mapper.Map<Employee, EmployeeModel>(employee);
            return model;
        }
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _db.Employees.Include(x => x.EmployeeDetails).ToListAsync();

            var employeesModel = _mapper.Map<List<Employee>, List<EmployeeViewModel>>(employees);
            return employeesModel;
        }

    }
}
