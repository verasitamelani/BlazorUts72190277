using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUts72190277.Models
{
    public class Employee
    {
        public int EmployeeId{ get; set;}
        public string FirstName{ get; set;}

        public string LastName{ get; set;}

        public string Email{ get; set;}

        public DateTime DateOfBirth{ get; set;}

        public int Gender{ get; set;}

        public int DepartmentId{ get; set;}

        public Department Department { get; set; }

        public string Photopath{ get; set;}
    }
}