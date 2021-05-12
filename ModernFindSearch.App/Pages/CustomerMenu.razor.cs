using Microsoft.AspNetCore.Components;
using ModernFindSearch.Shared;
using System;

namespace ModernFindSearch.App.Pages
{
    public partial class CustomerMenu
    {
        private string findCustomer { get; set; } = String.Empty;
        private string searchText { get; set; } = String.Empty;
        private Customer customer { get; set; } = new Customer();

        [Inject]
        public NavigationManager navigationManager { get; set; }

        public void FindCustomer()
        {
            if (int.Parse(findCustomer) > 0)
                customer.CustomerId = (int.Parse(findCustomer));
            else
                customer.CustomerId = 0;
            
            navigationManager.NavigateTo($"findcustomer/{customer.CustomerId}", false);
        }

        public void SearchCustomer()
        {
            if (!string.IsNullOrWhiteSpace(searchText))
                navigationManager.NavigateTo($"searchcustomer/{searchText}", false); 
        }
    }
}
