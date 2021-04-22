using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DTOModel.BusinessModel;
using BusinessLayer.GeneralInfoModule.Model.ViewModel;
using DataLayer;
using DataLayer.Helpers;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Services.GeneralInfoModule
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public EmployeeService(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<EmployeeModel> SaveEmployee(int EmployeeId, EmployeeModel model)
        {
            var employee = _mapper.Map<EmployeeModel, Employee>(model);
            if (EmployeeId > 0)
            {
                employee = await _db.Employees.FindAsync(EmployeeId);
                employee.Name = model.Name;
                employee.Designation = model.Designation;
            }
            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            model = _mapper.Map<Employee, EmployeeModel>(employee);
            return model;
        }
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {

            var employees = await _db.Employees.Include(x => x.EmployeeDetails).ToListAsync();
            var employees2 = await _db.Employees.Include(x => x.EmployeeDetails).AsSplitQuery().ToListAsync();
            var employeetest = await _db.Set<TestVm>().FromSqlRaw($"select * from Employees").ToListAsync();


            var employeesModel = _mapper.Map<List<Employee>, List<EmployeeViewModel>>(employees);
            return employeesModel;
        }

        public async Task<EmployeeViewModel> GetAllEmployee(int EmployeeId)
        {
            var employee = await _db.Employees.FindAsync(EmployeeId);
            var employeeViewModel = _mapper.Map<Employee, EmployeeViewModel>(employee);
            return employeeViewModel;
        }
    }
}
