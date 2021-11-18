using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Models;
using BlazorUts72190277.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUts72190277.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employees { get; set; } = new Employee();

        protected async override Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employees = await EmployeeService.GetById(int.Parse(id));
        }
       
    }
}