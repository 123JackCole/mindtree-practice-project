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
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return employees.GetAllEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = employees.GetEmployee(id);
            return employee == null ? NotFound() : employee;
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee(Employee employee)
        {
            if (employee == null) return BadRequest();

            var createdEmployee = employees.AddEmployee(employee);

            return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);

        }

        [HttpDelete]
        public ActionResult<Employee> DeleteEmployee(int id)
        {
            var employeeToDelete = employees.GetEmployee(id);

            if (employeeToDelete == null)
            {
                return NotFound($"Employee with Id = {id} not found");
            }

            employees.DeleteEmployee(employeeToDelete);
            return employeeToDelete;

        }

    }
}
