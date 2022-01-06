using System;
using System.Collections.Generic;
using System.Text;
using AspDotNetCore.DataAccess.Helpers;
using AspDotNetCore.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.DataAccess
{
    public class AspDotNetCoreDBContext : DbContext
    {

        public AspDotNetCoreDBContext(DbContextOptions<AspDotNetCoreDBContext> options) : base(options)
        {

        }

        //public AspDotNetCoreDBContext()
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ManageNonEntities();

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeDetails)
                .WithOne(ed => ed.Employees)
                .HasForeignKey<EmployeeDetails>(b => b.EmployeeId);


        }
        public DbSet<Employee> Employees { get; set; }
         //public DbSet<testvm> Employees { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
