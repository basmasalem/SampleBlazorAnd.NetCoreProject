using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public  class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Code { get; set; }
        public int? DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirhtOfDate { get; set; }
        public Department Department { get; set; }
    }
}
