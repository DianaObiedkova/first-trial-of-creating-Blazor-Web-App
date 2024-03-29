#pragma checksum "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c6af11f65e0922dc54de5c4b9e2ddedc93072c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAppBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using WebAppBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using WebAppBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using WebAppBlazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using EmployeeManagement.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
 if (Employee == null || Employee.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h1");
            __builder.AddContent(15, 
#nullable restore
#line 15 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 15 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h1");
            __builder.AddContent(20, 
#nullable restore
#line 16 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                         Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body text-center");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "class", "card-img-top");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 20 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                    Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                         e => Coordinates = $"X = {e.ClientX} Y = {e.ClientY}"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenElement(31, "h4");
            __builder.AddContent(32, "Employee ID : ");
            __builder.AddContent(33, 
#nullable restore
#line 23 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "h4");
            __builder.AddContent(36, "Email : ");
            __builder.AddContent(37, 
#nullable restore
#line 24 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                 Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "h4");
            __builder.AddContent(40, "Department : ");
            __builder.AddContent(41, 
#nullable restore
#line 25 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                      Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                           Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, 
#nullable restore
#line 27 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                                          ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 29 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", 
#nullable restore
#line 31 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                               $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "class", "btn btn-primary m-1");
            __builder.AddContent(56, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                                           Delete_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenComponent<EmployeeManagement.Components.Confirm>(68);
            __builder.AddAttribute(69, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 38 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                                            ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(70, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                                   $"Are you sure you want to delete \"{@Employee.FirstName}  {@Employee.LastName}\"?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(71, (__value) => {
#nullable restore
#line 38 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
                   DeleteConfirmation = (EmployeeManagement.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 41 "F:\Programs\Projects\git\WebAppBlazor\WebAppBlazor\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
