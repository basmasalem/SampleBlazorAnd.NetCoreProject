using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Repositories
{
   public interface IDepartmentRepository
    {

        Task<IEnumerable<Department>> GetAllDepartments();
        Task<Department> GetDepartment(int DepartmentId);
    }
}
