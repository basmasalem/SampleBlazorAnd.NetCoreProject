using Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Code { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirhtOfDate { get; set; }

    }
}
