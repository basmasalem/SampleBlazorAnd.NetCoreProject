using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Api.Repositories;
using Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                return Ok(await departmentRepository.GetAllDepartments());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error From Database");
            }
        }
     
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {

                var resulte = await departmentRepository.GetDepartment(id);
                if(resulte == null)
                {
                    return NotFound($"The Department With Id ={id} Not Found ");
                }
                return resulte;


            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
 
    }
}
