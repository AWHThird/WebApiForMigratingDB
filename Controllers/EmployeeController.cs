using WebApiForMigratingDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiForMigratingDB.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeProcessor employeeProcessor;

        public EmployeeController(IEmployeeProcessor employeeProcessor)
        {
            this.employeeProcessor = employeeProcessor;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeProcessor.GetEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody]Employee value)
        {
            employeeProcessor.CreateEmployee(value);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee value)
        {
            value.EmployeeId = id;
            employeeProcessor.UpdateEmployee(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employeeProcessor.DeleteEmployee(id);
        }
    }
}
