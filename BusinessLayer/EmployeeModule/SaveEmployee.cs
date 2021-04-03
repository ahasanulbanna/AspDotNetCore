using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer.EmployeeModule
{
    public class SaveEmployee : ISaveEmployee
    {
        public async Task<EmployeeModel> SaveEmployeeAsync(EmployeeModel model)
        {
            using (var context = new AspDotNetCoreDBContext())
            {

                var employee = new Employee
                {
                    EmployeeId=1,
                    Name = "Khan",
                };

                await context.Employees.AddAsync(employee);
                await context.SaveChangesAsync();

            }
            return model;
        }
    }
}
