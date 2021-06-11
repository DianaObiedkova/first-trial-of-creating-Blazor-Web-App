#pragma checksum "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54177a6f3be821ecb30d7d674fc6fde5b25f68cc"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Programs\Projects\c#\WebAppBlazor\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Confirm : ConfirmBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "h5");
            __builder.AddAttribute(18, "class", "modal-title");
            __builder.AddAttribute(19, "id", "exampleModalLabel");
            __builder.AddContent(20, 
#nullable restore
#line 9 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
                                                                    ConfirmationTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "close");
            __builder.AddAttribute(25, "data-dismiss", "modal");
            __builder.AddAttribute(26, "aria-label", "Close");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
                                      () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-body");
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.AddContent(35, 
#nullable restore
#line 16 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
                     ConfirmationMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-footer");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-secondary");
            __builder.AddAttribute(44, "data-dismiss", "modal");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
                                      () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "\r\n                        Cancel\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-danger");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
                                      () => OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "\r\n                        Delete\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 31 "F:\Programs\Projects\c#\WebAppBlazor\Components\Confirm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
