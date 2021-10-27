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

        private readonly IEmployeeRepository employees;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employees = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            try
            {
                IEnumerable<Employee> returnedEmployees = await employees.GetAllEmployees();
                return this.Ok(returnedEmployees);
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
                return employee == null ? StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving employee") : this.Ok(employee);
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
                if (ModelState.IsValid)
                {
                    var createdEmployee = await employees.AddEmployee(employee);

                    return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Employee is not valid");
                }

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating new employee");
            }

        }

        [HttpPut]
        public async Task<ActionResult<Employee>> EditEmployee(int id, Employee editedEmployee)
        {
            try
            {
                if (id != editedEmployee.Id) return BadRequest("Employee Id does not match");

                var employeeToEdit = await employees.GetEmployee(id);

                if (employeeToEdit == null) return NotFound($"Employee with Id = {id} not found");

                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Employee is not valid");
                }

                return await employees.EditEmployee(employeeToEdit, editedEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            try
            {
                var employeeToDelete = await employees.GetEmployee(id);

                if (employeeToDelete == null)
                {
                    return this.BadRequest($"Employee with Id = {id} not found");
                }

                await employees.DeleteEmployee(employeeToDelete);
                return this.NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }

        }

    }
}
