#pragma checksum "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce5bf8e1459862529c1545fd1e1fd7a82b1b0d98"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailprofile/{id}")]
    public partial class DetailProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
 if (Employees == null || Employees.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 6 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-6-mt-3");
            __builder.OpenElement(5, "center");
            __builder.OpenElement(6, "h1");
            __builder.AddAttribute(7, "class", "tag2 tag2-pink");
            __builder.AddContent(8, 
#nullable restore
#line 11 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                         Employees.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                                              Employees.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header text-center");
            __builder.OpenElement(14, "center");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 13 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                       Employees.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                                           Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                   ");
            __builder.OpenElement(19, "h5");
            __builder.AddContent(20, 
#nullable restore
#line 14 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                         Coordinate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, "Employee Id : ");
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                      Employees.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, "Email : ");
            __builder.AddContent(28, 
#nullable restore
#line 16 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                Employees.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, "Date Of Birth : ");
            __builder.AddContent(32, 
#nullable restore
#line 17 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                        Employees.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, "Gender : ");
            __builder.AddContent(36, 
#nullable restore
#line 18 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                 Employees.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, "Department Name : ");
            __builder.AddContent(40, 
#nullable restore
#line 19 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                          Employees.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "center");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-outline-primary btn-lg");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                                                    Btn_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, 
#nullable restore
#line 21 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                                                                ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 22 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "<a href=\"/employeeprofile\" class=\"btn btn-outline-primary btn-lg\"> Back</a>\r\n                    ");
            __builder.AddMarkupContent(51, "<a href=\"#\" class=\"btn btn-outline-success btn-lg\"> Edit</a>\r\n                    ");
            __builder.AddMarkupContent(52, "<a href=\"#\" class=\"btn btn-outline-danger btn-lg\"> Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Frontend\BlazorUts72190277\Pages\DetailProfile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
