using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Services;
using BlazorUts72190277.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUts72190277.Pages
{
    public partial class EmployeeProfile
    {
        public List<Employee> EmployeesProfile { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        protected async override Task OnInitializedAsync()
        {
            EmployeesProfile = (await EmployeeService.GetAll()).ToList();    
        }
    }
}