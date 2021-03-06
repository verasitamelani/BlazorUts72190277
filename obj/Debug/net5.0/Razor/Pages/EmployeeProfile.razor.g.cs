#pragma checksum "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b5c17315c93076c393c2a86b489734c06bcb3a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUts72190277.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using BlazorUts72190277;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Frontend\BlazorUts72190277\_Imports.razor"
using BlazorUts72190277.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeprofile")]
    public partial class EmployeeProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
 if (EmployeesProfile == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 6 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 10 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
         foreach (var emp in EmployeesProfile)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3");
            __builder.AddAttribute(5, "style", "min-width:18rem; max-width:30%");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "class", "card-img-top img-thumbnail");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 13 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                                                              emp.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.AddMarkupContent(12, "<span class=\"tagnew tagnew-pink\">Profile</span>\r\n                        ");
            __builder.OpenElement(13, "h4");
            __builder.OpenElement(14, "b");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                             emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                                            emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "<img src=\"images\\deptname.png\" width=\"25\" height=\"25\"> ");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                                                                                 emp.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "<img src=\"images\\email.png\" width=\"25\" height=\"25\">  ");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                                                                               emp.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-footer text-center");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 28 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                               $"detailprofile/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-outline-primary btn-sm");
            __builder.AddContent(32, " Lihat");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 29 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                               $"editemployee/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "class", "btn btn-outline-success btn-sm");
            __builder.AddContent(37, " Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 30 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
                               $"deleteemployee/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "class", "btn btn-outline-danger btn-sm");
            __builder.AddContent(42, " Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"
            

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Frontend\BlazorUts72190277\Pages\EmployeeProfile.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
