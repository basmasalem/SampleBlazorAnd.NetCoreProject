using Core.Model;
using Core.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
      
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public int Id {get;set;}
        public IEnumerable<Employee> Employees { get; set; }
        public event Action RefreshRequested;
        protected override async  Task OnInitializedAsync()
        {
            Employees =( await employeeService.GetEmployees()).ToList();
        }

        protected async void Delete_Item(int id)
        {
            await employeeService.DeleteEmployee(id);
            Employees = (await employeeService.GetEmployees()).ToList();
            StateHasChanged();
        }
    }
}
