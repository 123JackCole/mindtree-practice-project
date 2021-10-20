using EMS_backend.Data.Interfaces;
using EMS_backend.Data.Models;
using EMS_backend.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private IEmployeeRepository employees = new EmployeeRepository();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            try
            {
                return await employees.GetAllEmployees();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving employee list");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var employee = await employees.GetEmployee(id);
                return employee == null ? NotFound() : employee;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving employee");
            }
                
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
                if (employee == null) return BadRequest();
                if (ModelState.IsValid) {
                    var createdEmployee = await employees.AddEmployee(employee);

                    return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
                } else {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Employee is not valid");
                }

                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating new employee");
            }

        }

        [HttpPut]
        public async Task<ActionResult<Employee>> EditEmployee(Employee employee) 
        {
            try
            {
                var employeeToEdit = await employees.GetEmployee(id);

                if (employeeToEdit == null) return NotFound($"Employee with Id = {id} not found");

                if (!ModelState.IsValid) {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Employee is not valid");
                }

                return await employees.EditEmployee(employeeToEdit);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var employeeToDelete = employees.GetEmployee(id);

                if (employeeToDelete == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }

                await employees.DeleteEmployee(employeeToDelete);
                return employeeToDelete;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }

        }

    }
}
