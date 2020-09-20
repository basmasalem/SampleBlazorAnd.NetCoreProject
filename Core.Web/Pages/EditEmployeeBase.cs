using AutoMapper;
using Core.Model;
using Core.Web.AutoMapper;
using Core.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.Pages
{
    public class EditEmployeeBase: ComponentBase
    {

        [Inject]
        public IEmployeeService employeeService { get; set; }
        [Inject]
        public IDepartmentService departmentService { get; set; }
        [Inject]
        public IMapper mapper { get; set; }
        public EditEmployeeModel editEmployeeModel { get; set; } = new EditEmployeeModel();

        public List<Department> Departments { get; set; } = new List<Department>();
        public Employee employee { get; set; } = new Employee();
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            int id = int.Parse(Id);
            if ( id > 0)
            {
                employee = (await employeeService.GetEmployeeDetails(id));
            }
          
            Departments = (await departmentService.GetDepartments()).ToList();
            mapper.Map(employee, editEmployeeModel);
        }

        public  async Task HandleValidSubmit()
        {

             mapper.Map(editEmployeeModel, employee);
             if(employee .EmployeeId== 0) {
                await employeeService.AddEmployee(employee);
            }
             else {
                await employeeService.UpdateEmployee(employee);

            }
            NavigationManager.NavigateTo("/", true);
        }

    }
}
