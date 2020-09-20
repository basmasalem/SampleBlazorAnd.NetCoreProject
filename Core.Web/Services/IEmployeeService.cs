using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Core.Web.Services
{
   public  interface IEmployeeService
    {

        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployeeDetails(int Id);
        public Task UpdateEmployee(Employee employee);
        public Task AddEmployee(Employee employee);
        public Task<HttpResponseMessage> DeleteEmployee(int Id);
    }
}
