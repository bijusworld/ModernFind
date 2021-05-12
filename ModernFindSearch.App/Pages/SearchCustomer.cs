using Microsoft.AspNetCore.Components;
using ModernFindSearch.App.Services;
using ModernFindSearch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Pages
{
    public partial class SearchCustomer
    {
        [Parameter]
        public string searchText { get; set; }
        public IEnumerable<Customer> customers { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            customers = await CustomerDataService.SearchCustomers(searchText.ToLower());
        }

        protected void NavigateToCustomerMenu()
        {
            NavigationManager.NavigateTo("/CustomerMenu");
        }

    }
}
