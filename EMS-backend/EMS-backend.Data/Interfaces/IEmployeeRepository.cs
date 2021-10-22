using EMS_backend.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS_backend.Data.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        //Employee GetEmployee(int id);
        Task<Employee> GetEmployee(int id);

        //Employee AddEmployee(Employee employee);
        Task<Employee> AddEmployee(Employee employee);

        //Employee EditEmployee(Employee employee);
        Task<Employee> EditEmployee(Employee employeeToEdit, Employee editedEmployee);

        Task<bool> DeleteEmployee(Employee employee);
    }
}
