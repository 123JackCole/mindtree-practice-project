using EMS_backend.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS_backend.Data.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployee(int id);
    }
}
