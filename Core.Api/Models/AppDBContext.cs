using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
          
        }
        public DbSet<Department> Depatrments{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 1, DeparmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 2, DeparmentName = "CS" });
            modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 3, DeparmentName = "CIS" });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                BirhtOfDate = new DateTime(1982, 5, 4),
                DepartmentId = 1,
                Email = "empmohamed@yahoo.com",
                EmployeeId = 1,
                FirstName = "mohamed",
                Gender = Gender.Male,
                LastName = "salem",
                PhotoPath = "images/icon/avatar-01.jpg",
                Code = "EMP1"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                BirhtOfDate = new DateTime(1982, 5, 4),
                DepartmentId =  1,
                Email = "empAhmed@yahoo.com",
                EmployeeId = 2,
                FirstName = "Ahmed",
                Gender = Gender.Male,
                LastName = "salem",
                PhotoPath = "images/icon/avatar-03.jpg",
                Code = "EMP2"

            });
            modelBuilder.Entity<Employee>().HasData( new Employee()
            {
                BirhtOfDate = new DateTime(1982, 5, 4),
                DepartmentId = 2,
                Email = "empHana@yahoo.com",
                EmployeeId = 3,
                FirstName = "Hana",
                Gender = Gender.Female,
                LastName = "salem",
                PhotoPath = "images/icon/avatar-02.jpg",
                Code = "EMP3"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                BirhtOfDate = new DateTime(1982, 5, 4),
                DepartmentId = 3,
                Email = "empLana@yahoo.com",
                EmployeeId = 4,
                FirstName = "Lana",
                Gender = Gender.Female,
                LastName = "salem",
                PhotoPath = "images/icon/avatar-02.jpg",
                Code = "EMP4"

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
