#pragma checksum "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63e93f3d898a1e319a71646837c4a089e4af266"
// <auto-generated/>
#pragma warning disable 1591
namespace ModernFindSearch.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using ModernFindSearch.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\_Imports.razor"
using ModernFindSearch.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
using ModernFindSearch.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Customer Search</h3>\r\n");
            __builder.AddMarkupContent(1, "<div><br></div>\r\n");
            __builder.OpenElement(2, "form");
            __builder.AddAttribute(3, "name", "formOne");
            __builder.AddAttribute(4, "method", "post");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        Customer ID :\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                                             (e) => { findCustomer=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                   findCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => findCustomer = __value, findCustomer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "submit");
            __builder.AddAttribute(15, "value", "  Find  ");
            __builder.AddAttribute(16, "placeholder", "Find");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                                                           FindCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n        Search Customer :\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                                           (e) => { searchText=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                   searchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchText = __value, searchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "submit");
            __builder.AddAttribute(29, "value", "Search");
            __builder.AddAttribute(30, "placeholder", "Search");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\Index.razor"
                                                                           SearchCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
