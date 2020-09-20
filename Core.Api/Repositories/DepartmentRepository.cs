using Core.Api.Models;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDBContext _appDBContext;

        public DepartmentRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _appDBContext.Depatrments.ToListAsync();
        }

        public async Task<Department> GetDepartment(int DepartmentId)
        {
            var dept = await _appDBContext.Depatrments.Where(d => d.DepartmentId == DepartmentId).FirstOrDefaultAsync();
            return dept;
        }
    }
}
