using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Models;
using BlazorUts72190277.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUts72190277.Pages
{
    public partial class DeleteEmployee
    {
        [Parameter]

        public string Id { get; set;}

        [Inject]
        public IEmployeeService EmployeeService{ get; set; }
    
        [Inject]
        public NavigationManager NavigationManager {get; set;}
    
        protected async override Task OnInitializedAsync()
        {
            await EmployeeService.Delete(int.Parse(Id));
            NavigationManager.NavigateTo("/employeeprofile");
        }

    
    }
}