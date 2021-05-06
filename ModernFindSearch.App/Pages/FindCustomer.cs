using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModernFindSearch.App.Services;

namespace ModernFindSearch.App.Pages
{
    public partial class FindCustomer
    {
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        public bool Saved;
        [Parameter]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public IEnumerable<Customer> Customers { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }

        protected override async Task<Task> OnInitializedAsync()
        {
            Saved = false;
            //InitializeCustomers();
            //Customer = Customers.FirstOrDefault(c => c.CustomerId == int.Parse(CustomerId));
            ////if (Customer.CustomerId == 0) //new
            ////{
            ////    Message = "Key in a valid Id.";
            ////}
            ////else
            ////{
            ////    Customer = Customers.FirstOrDefault(c => c.CustomerId == int.Parse(CustomerId));
            ////    Message = "Click home to search again.";
            ////    Saved = true;
            ////}

            //Customer = await CustomerDataService.GetCustomer(int.Parse(CustomerId));
            Customer customer = new Customer { CustomerId = 3, CustomerCategory = CustomerCategory.B2C, CustomerName = "New Look LTD", Street = "Elvis Lane", PostCode = "TW16", City = "London" };
            var addedCustomer = await CustomerDataService.AddCustomer(customer);

            return base.OnInitializedAsync();
        }



        private void InitializeCustomers()
        {
            var c1 = new Customer
            {
                CustomerId = 1,
                CustomerCategory = CustomerCategory.B2B,
                CustomerName = "XYZ Business Ltd.",
                Street = "Elvis Lane",
                PostCode = "TW16",
                City = "London",
            };

            var c2 = new Customer
            {
                CustomerId = 2,
                CustomerCategory = CustomerCategory.B2C,
                CustomerName = "ABC Informatics Ltd.",
                Street = "Bankers street",
                PostCode = "TW03",
                City = "London",
            };

            Customers = new List<Customer> { c1, c2 };
        }

        protected void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
