#pragma checksum "/Users/d054341/Projects/test2/test2/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52303c2ea3a0d4be2cf283e5f07cc9115d96ee61"
// <auto-generated/>
#pragma warning disable 1591
namespace test2
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using test2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using test2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using test2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/d054341/Projects/test2/test2/_Imports.razor"
using test2.Pages;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n    ");
                __builder2.OpenComponent<Blazored.Modal.CascadingBlazoredModal>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(6);
                    __builder3.AddAttribute(7, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 4 "/Users/d054341/Projects/test2/test2/App.razor"
                              typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder4) => {
                        __builder4.AddMarkupContent(9, "\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(10);
                        __builder4.AddAttribute(11, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "/Users/d054341/Projects/test2/test2/App.razor"
                                                routeData

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "/Users/d054341/Projects/test2/test2/App.razor"
                                                                           typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(13, "\n            ");
                    }
                    ));
                    __builder3.AddAttribute(14, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(16);
                        __builder4.AddAttribute(17, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 9 "/Users/d054341/Projects/test2/test2/App.razor"
                                     typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(19, "\n                    ");
                            __builder5.AddMarkupContent(20, "<p>Sorry, there\'s nothing at this address.</p>\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
