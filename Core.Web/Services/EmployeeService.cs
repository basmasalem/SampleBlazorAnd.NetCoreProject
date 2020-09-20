using Core.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Core.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/Employees");
        }
        public async Task<Employee> GetEmployeeDetails(int Id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/Employees/{Id}");
        }

        public async Task<HttpResponseMessage> DeleteEmployee(int Id)
        {
            return await _httpClient.DeleteAsync( $"api/Employees/{Id}");
        }

        public async Task UpdateEmployee(Employee employee)
        {
             await _httpClient.PutJsonAsync($"api/Employees",employee);
        }

        public async Task  AddEmployee(Employee employee)
        {
            await _httpClient.PostJsonAsync($"api/Employees", employee);
        }
    }
}
