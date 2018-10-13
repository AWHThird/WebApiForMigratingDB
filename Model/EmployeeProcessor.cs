using Dapper;
using System.Data;
using System.Data.SqlClient;
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

            using (var connection = new SqlConnection(connectionString))
            {
                employee = connection.Query<Employee>("spGetEmployees",
                    commandType: CommandType.StoredProcedure);
            }

            return employee;
        }

        public void CreateEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(int employeeId)
        {

        }
    }
}