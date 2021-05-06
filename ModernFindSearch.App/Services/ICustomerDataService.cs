using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Services
{
    public interface ICustomerDataService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(int customerId);
        Task<Customer> AddCustomer(Customer customer);
    }
}
