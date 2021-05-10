#pragma checksum "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112942499830db1799cb6e8fae3d150d81fa12c0"
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
#line 3 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
using ModernFindSearch.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/searchcustomer/{searchText}")]
    public partial class SearchCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
 if (customers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3 class=\"page-title\">Search Results</h3>\r\n    ");
            __builder.AddMarkupContent(2, "<div><br></div>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Customer Name</th>\r\n                <th>Category</th>\r\n                <th>Customer Details</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 22 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
             foreach (var customer in customers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 25 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                         customer.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 26 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                         customer.CustomerCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                         customer.Street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, ", ");
            __builder.AddContent(17, 
#nullable restore
#line 27 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                                           customer.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, ", ");
            __builder.AddContent(19, 
#nullable restore
#line 27 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                                                           customer.PostCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "class", "btn btn-outline-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"
                                                  NavigateToHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Home");
            __builder.CloseElement();
#nullable restore
#line 34 "C:\JUBIWORKS\Books\PluralSight\Blazor\WorkArea\02\ModernFindSearch.App\ModernFind\ModernFindSearch.App\Pages\SearchCustomer.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591