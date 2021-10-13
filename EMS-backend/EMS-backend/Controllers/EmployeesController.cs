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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Employee list here!" };
        }

        //public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        //{
        //    return employees;
        //}

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "the value is " + id;
        }

    }
}
