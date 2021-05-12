using Microsoft.AspNetCore.Components;
using ModernFindSearch.Shared;
using System;

namespace ModernFindSearch.App.Pages
{
    public partial class ProductMenu
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public ProductFilter inputFilter { get; set; } = new ProductFilter();

        public string url = "productlist";
        public void SubmitFilter()
        {
            if (!string.IsNullOrWhiteSpace(inputFilter.ProductReference))
            {
                url = "productlist/" + inputFilter.ProductReference;
            }
            else
            {
                url = "productlist";
            }
            NavigationManager.NavigateTo(url, false);
        }
    }
}
