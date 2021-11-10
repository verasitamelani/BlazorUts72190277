using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Models;
using BlazorUts72190277.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorUts72190277.Pages
{
    public partial class DetailProfile
    {
        [Parameter]
        public string id { get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employees  { get; set; } = new Employee();

        public string Coordinate{ get; set; }

        protected void Mouse_Move(MouseEventArgs e){
            Coordinate = $"X = {e.ClientX},Y ={e.ClientY}";
        }

        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        protected void Btn_Click(){
            if(ButtonText == "Hide Footer"){
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            } else{
                CssClass = null;
                ButtonText="Hide Footer";
            }
        }

        protected async override Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employees = await EmployeeService.GetById(int.Parse(id));
        }
    }
}