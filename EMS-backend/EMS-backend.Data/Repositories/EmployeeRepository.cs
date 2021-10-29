using EMS_backend.Data.Interfaces;
using EMS_backend.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_backend.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            await Task.Delay(1000);
            return EmployeeList.employeeList;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            await Task.Delay(1000);
            return EmployeeList.employeeList.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Employee> AddEmployee(Employee employeeToAdd)
        {
            await Task.Delay(1000);
            employeeToAdd.Id = EmployeeList.employeeList[EmployeeList.employeeList.Count - 1].Id + 1;
            EmployeeList.employeeList.Add(employeeToAdd);
            return employeeToAdd;
        }

        /*private int FindEmployee(Employee employeeToFind)
        {
            return employees.FindIndex(ind => ind.Equals(employeeToFind));
        }*/

        public async Task<Employee> EditEmployee(Employee employeeToEdit, Employee editedEmployee)
        {
            await Task.Delay(1000);
            return EmployeeList.employeeList[EmployeeList.employeeList.FindIndex(ind => ind.Equals(employeeToEdit))] = editedEmployee;
        }

        public async Task<bool> DeleteEmployee(Employee employeeToDelete)
        {
            await Task.Delay(1000);
            return EmployeeList.employeeList.Remove(employeeToDelete);
        }
    }
}
