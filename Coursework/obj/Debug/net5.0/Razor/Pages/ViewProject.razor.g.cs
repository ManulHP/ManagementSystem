#pragma checksum "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "858888b36b62fb74cf6801eeb9cc81da9f9282e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Coursework.Pages
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
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
using Coursework.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewPorject")]
    public partial class ViewProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
 if (EmpObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Fetching data... Please wait !</em></p>");
#nullable restore
#line 15 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"row\"><div class=\"col-lg-9\"><h1>WorkSpace</h1></div></div>");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-borderless table-striped table-sm col px-md-2");
            __builder.AddMarkupContent(4, @"<thead class=""thead-dark""><tr><th style=""width:100px"">Title</th>
                <th style=""width:200px"">Comapany Name</th>
                <th style=""width:800px"">Description</th>
                <th style=""width:200px"">Project Type</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 37 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
             foreach (var emp in EmpObj)
            {
                if (emp.ProjectType == "Workplace") { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 41 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 42 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 43 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 44 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.ProjectType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "text-right");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(23, "href", "Dash/" + (
#nullable restore
#line 46 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                               emp.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 46 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                       emp.ProjectType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "role", "button");
            __builder.AddContent(25, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "class", "btn btn-primary btn-sm");
                __builder2.AddAttribute(31, "href", "EditProject/" + (
#nullable restore
#line 49 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                 emp.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 49 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                         emp.ProjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "role", "button");
                __builder2.AddContent(33, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenElement(35, "a");
                __builder2.AddAttribute(36, "class", "btn btn-danger btn-sm");
                __builder2.AddAttribute(37, "href", "DeleteProject/" + (
#nullable restore
#line 50 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                  emp.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 50 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                          emp.ProjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "role", "button");
                __builder2.AddContent(39, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(40, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(41, "<a class=\"btn btn-secondary btn-sm\" role=\"button\">Edit</a>\r\n                            ");
                __builder2.AddMarkupContent(42, "<a class=\"btn btn-secondary btn-sm\" role=\"button\">Delete</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table table-borderless table-striped table-sm col px-md-2");
            __builder.AddMarkupContent(45, "<thead class=\"thead-dark\"><tr><th style=\"width:100px\">Title</th>\r\n                <th style=\"width:800px\">Description</th>\r\n                <th style=\"width:200px\">Project Type</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(46, "tbody");
#nullable restore
#line 75 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
             foreach (var emp in EmpObj)
            {
                if (emp.ProjectType == "Individual")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "tr");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 80 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 81 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 82 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.ProjectType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "class", "text-right");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(61, "href", "Dash/" + (
#nullable restore
#line 84 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                               emp.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 84 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                       emp.ProjectType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "role", "button");
            __builder.AddContent(63, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(65);
            __builder.AddAttribute(66, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(67, "a");
                __builder2.AddAttribute(68, "class", "btn btn-primary btn-sm");
                __builder2.AddAttribute(69, "href", "EditProject/" + (
#nullable restore
#line 87 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                 emp.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 87 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                         emp.ProjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "role", "button");
                __builder2.AddContent(71, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.OpenElement(73, "a");
                __builder2.AddAttribute(74, "class", "btn btn-danger btn-sm");
                __builder2.AddAttribute(75, "href", "DeleteProject/" + (
#nullable restore
#line 88 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                  emp.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 88 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                                          emp.ProjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "role", "button");
                __builder2.AddContent(77, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(78, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(79, "<a class=\"btn btn-secondary btn-sm\" role=\"button\">Edit</a>\r\n                            ");
                __builder2.AddMarkupContent(80, "<a class=\"btn btn-secondary btn-sm\" role=\"button\">Delete</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
       
    List<Coursework.Data.Project.Project> EmpObj;
    protected override async Task OnInitializedAsync()
    {
        EmpObj = await Task.Run(() => projectService.GetAllProjectAsync());

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Ticket.TicketService ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Project.ProjectService projectService { get; set; }
    }
}
#pragma warning restore 1591
