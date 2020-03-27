using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsEmployeesAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public String DeptName { get; set; }
    }
}
