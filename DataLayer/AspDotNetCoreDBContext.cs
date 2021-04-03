using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AspDotNetCoreDBContext: DbContext
    {
        public AspDotNetCoreDBContext()
        {
        }

        public AspDotNetCoreDBContext(DbContextOptions<AspDotNetCoreDBContext> options) : base(options)
            {
            }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
    }
}
