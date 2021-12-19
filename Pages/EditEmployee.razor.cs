using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Models;
using BlazorUts72190277.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUts72190277.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService Employeeservice { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager {get; set;}
        public List<Department> Departments{ get; set;} = new List<Department>();

        [Parameter]
        public string id{ get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await Employeeservice.GetById(int.Parse(id));
            Departments = (await DepartmentService.GetAll()).ToList();
        }

        protected async Task Delete_click(){
            await Employeeservice.Delete(Employee.EmployeeId);
            NavigationManager.NavigateTo("/employeeprofile");
        }

        protected async Task HandleValidSubmit(){
            Employee.Photopath = "images/nophoto.jpg";
            Employee results = await Employeeservice.Update(int.Parse(id), Employee);
            NavigationManager.NavigateTo("/employeeprofile");
        }

    }
}