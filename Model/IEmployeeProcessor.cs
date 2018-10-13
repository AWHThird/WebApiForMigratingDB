using System.Collections;
using System.Collections.Generic;

namespace WebApiForMigratingDB.Model
{
    public interface IEmployeeProcessor
    {
        IEnumerable<Employee> GetEmployees();
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
