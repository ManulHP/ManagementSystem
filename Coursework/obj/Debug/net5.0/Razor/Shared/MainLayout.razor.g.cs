#pragma checksum "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3750c544b0a7bd51fd68cdeedb0233229422ffb"
// <auto-generated/>
#pragma warning disable 1591
namespace Coursework.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "site-header sticky-top py-1");
            __builder.AddAttribute(2, "b-35uie38b0r");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "container d-flex flex-column flex-md-row justify-content-between");
            __builder.AddAttribute(5, "b-35uie38b0r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "py-2 d-none d-md-inline-block");
            __builder.AddAttribute(8, "href", "");
            __builder.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Shared\MainLayout.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-35uie38b0r></span> Dashboard\r\n          ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n          ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "py-2 d-none d-md-inline-block");
            __builder.AddAttribute(15, "href", "ViewPorject");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-35uie38b0r></span> Projects\r\n          ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n          ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "py-2 d-none d-md-inline-block");
            __builder.AddAttribute(21, "href", "AddProject");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-35uie38b0r></span> Create\r\n          ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n          ");
            __builder.OpenComponent<Coursework.Shared.LoginDisplay>(25);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\r\n    ");
            __builder.OpenElement(27, "main");
            __builder.AddAttribute(28, "class", "content px-4");
            __builder.AddAttribute(29, "b-35uie38b0r");
            __builder.AddContent(30, 
#nullable restore
#line 20 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
