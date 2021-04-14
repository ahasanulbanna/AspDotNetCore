using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AspDotNetCoreDBContext : DbContext
    {

        public AspDotNetCoreDBContext(DbContextOptions<AspDotNetCoreDBContext> options) : base(options)
        {

        }

        public AspDotNetCoreDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeDetails)
                .WithOne(ed => ed.Employees)
                .HasForeignKey<EmployeeDetails>(b => b.EmployeeId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
