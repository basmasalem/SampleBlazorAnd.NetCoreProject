using Core.Api.Models;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext _appDBContext;
        public EmployeeRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
           var resulte= await  _appDBContext.Employees.AddAsync(employee);
            await _appDBContext.SaveChangesAsync();
            return resulte.Entity;

        }

        public async Task<string> DeleteEmployee(int EmployeeId)
        {
          var emp= await _appDBContext.Employees.Where(e => e.EmployeeId == EmployeeId).FirstOrDefaultAsync();
            if(emp !=null)
            {
                _appDBContext.Employees.Remove(emp);
                await   _appDBContext.SaveChangesAsync();
                return "1";
            }
            return "0";
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _appDBContext.Employees.Include(d=>d.Department).ToListAsync();
        }

        public async Task<Employee> GetEmployee(int EmployeeId)
        {
            return await _appDBContext.Employees.Where(e=>e.EmployeeId==EmployeeId).FirstOrDefaultAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var emp = await _appDBContext.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefaultAsync();
            if (emp != null)
            {
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.BirhtOfDate = employee.BirhtOfDate;
                emp.DepartmentId = employee.DepartmentId;
                emp.Email = employee.Email;
                emp.Gender = employee.Gender;
                emp.PhotoPath = employee.PhotoPath;
              await  _appDBContext.SaveChangesAsync();

            }
            return emp;
        }
    }
}
