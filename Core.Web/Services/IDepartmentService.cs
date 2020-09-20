using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Core.Web.Services
{
   public  interface IDepartmentService
    {

        public Task<IEnumerable<Department>> GetDepartments();
        public Task<Department> GetDepartment(int Id);
     
    }
}
