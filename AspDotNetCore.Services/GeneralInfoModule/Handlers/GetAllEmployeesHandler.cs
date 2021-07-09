using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess;
using AspDotNetCore.DataAccess.Helpers;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.DTOModel.ViewModel;
using AspDotNetCore.Services.GeneralInfoModule.Queries;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Services.GeneralInfoModule.Handlers
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeViewModel>>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public GetAllEmployeesHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<EmployeeViewModel>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _db.Employees.Include(x => x.EmployeeDetails).ToListAsync();
            var employees2 = await _db.Employees.Include(x => x.EmployeeDetails).AsSplitQuery().ToListAsync();
            var employeetest = await _db.Set<TestVm>().FromSqlRaw($"select * from Employees").ToListAsync();


            var employeesModel = _mapper.Map<List<Employee>, List<EmployeeViewModel>>(employees);
            return employeesModel;
        }
    }
}
