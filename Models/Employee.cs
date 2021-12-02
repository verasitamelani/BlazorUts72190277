using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUts72190277.Models
{
    public class Employee
    {
        public int EmployeeId{ get; set;}

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2 )]
        public string FirstName{ get; set;}

        [Required]
        public string LastName{ get; set;}
        [Required]
        public string Email{ get; set;}

        public DateTime DateOfBirth{ get; set;}

        public Gender Gender{ get; set;}

        public int DepartmentId{ get; set;}

        public Department Department { get; set; }

        public string Photopath{ get; set;}
    }

    public enum Gender{
        Male, Female    
    }
}