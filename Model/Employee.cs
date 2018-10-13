using System;

namespace WebApiForMigratingDB.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string JobTitle { get; set; }
        public string HomeAddress { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Employed { get; set; }
    }
}
