using Microsoft.AspNetCore.Components;
using ModernFindSearch.App.Services;
using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Pages
{
    public partial class ProductList
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public List<Product> Products { get; set; }
        [Inject]
        public IProductDataService ProductDataService { get; set; }
        [Parameter]
        public string Filter { get; set; }

        //1 public HttpClient HttpClient { get; set; }
        protected async override Task OnInitializedAsync()
        {
            //1 var products = await HttpClient.GetFromJsonAsync<List<Product>>("https://localhost:58632/api/Product");
            //2 InitializeProducts();
            if (Filter is null)
            {
                Products = (await ProductDataService.GetAllProducts()).ToList();
            }
            else
            {
                //Products = (await ProductDataService.GetAllProducts(Filter)).ToList();
                ProductFilter searchdesc = new ProductFilter();
                searchdesc.ProductReference = Filter;
                Products = (await ProductDataService.PostAllProductsFilter(searchdesc)).ToList();
            }
            var test = Products;
            //return base.OnInitializedAsync(); 
        }
        protected void NavigateToProductMenu()
        {
            NavigationManager.NavigateTo("/ProductMenu");
        }
    }
}
