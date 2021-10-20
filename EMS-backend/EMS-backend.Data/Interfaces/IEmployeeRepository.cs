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

        // work on 3 data types below
        Employee AddEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

        bool DeleteEmployee(Employee employee);
    }
}
