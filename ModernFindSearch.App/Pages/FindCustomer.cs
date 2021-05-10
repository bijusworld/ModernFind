using ModernFindSearch.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModernFindSearch.App.Services;

namespace ModernFindSearch.App.Pages
{
    public partial class FindCustomer
    {
        [Parameter]
        public string customerId { get; set; }
        public Customer customer { get; set; } = new Customer();

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            customer = await CustomerDataService.GetCustomer(int.Parse(customerId));
        }

        protected void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
