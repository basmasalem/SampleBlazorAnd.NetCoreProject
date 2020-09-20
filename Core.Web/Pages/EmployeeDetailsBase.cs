using Core.Model;
using Core.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.Pages
{
    public class EmployeeDetailsBase: ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();
        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employee = (await employeeService.GetEmployeeDetails(int.Parse(Id)));
        }
    }
}
