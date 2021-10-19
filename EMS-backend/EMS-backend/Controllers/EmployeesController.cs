using EMS_backend.Data.Interfaces;
using EMS_backend.Data.Models;
using EMS_backend.Data.Repositories;
using EMS_backend.Models;
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
        /*public IEnumerable<string> Get()
        {
            return new string[] { "Employee list here!" };
        }*/

        private IEmployeeRepository employees = new EmployeeRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return employees.GetAllEmployees();
        }

        /*public string Get(int id)
        {
            return "the value is " + id;
        }*/

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = employees.GetEmployee(id);
            return employee == null ? NotFound() : employee;
        }

    }
}
