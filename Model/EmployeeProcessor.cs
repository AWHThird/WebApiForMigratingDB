using System.Collections;
using System.Collections.Generic;

namespace WebApiForMigratingDB.Model
{
    public class EmployeeProcessor : IEmployeeProcessor
    {
        private readonly string connectionString;

        public EmployeeProcessor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            IEnumerable<Employee> employee = null;

            return employee;
        }

        public void CreateEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(Employee employee)
        {

        }
    }
}