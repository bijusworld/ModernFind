using ModernFindSearch.Shared;
using System;

namespace ModernFindSearch.App.Pages
{
    public partial class Index
    {
        private string CurrentValue { get; set; } = String.Empty;
        private Customer Customer { get; set; } = new Customer();

        public void Button_Click()
        {
            if (int.Parse(CurrentValue) > 0)
                Customer.CustomerId = (int.Parse(CurrentValue));
            else
                Customer.CustomerId = 0;
            
            navigationManager.NavigateTo($"findcustomer/{Customer.CustomerId}", false);

        }



    }
}
