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
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                return Ok(await employeeRepository.GetAllEmployees());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error From Database");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Employee>>CreateEmployee(Employee employee)
        {
            try
            {
                if(employee==null)
                {
                    return BadRequest();
                }
                else
                {
                    var resulte = await employeeRepository.AddEmployee(employee);
                    return CreatedAtAction(nameof(GetEmployee), new { id = resulte.EmployeeId }, resulte);
                }
              
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {

                var resulte = await employeeRepository.GetEmployee(id);
                if(resulte == null)
                {
                    return NotFound($"The Employee With Id ={id} Not Found ");
                }
                return resulte;


            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPut]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee employee)
        {
            try
            {
                var resulte = await employeeRepository.GetEmployee(employee.EmployeeId);
                if (resulte == null)
                {
                    return NotFound($"The Employee With Id ={employee.EmployeeId} Not Found ");
                }
                else
                {
                    resulte = await employeeRepository.UpdateEmployee(employee);
                    return resulte;
                }
               
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id )
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       {
            try
            {
                var resulte = await employeeRepository.GetEmployee(id);
                if (resulte == null)
                {
                    return NotFound($"The Employee With Id ={id} Not Found ");
                }
                else
                {
                     await  employeeRepository.DeleteEmployee(id);
                    return Ok("Deleted Successfully");
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
