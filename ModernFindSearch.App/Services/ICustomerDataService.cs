using ModernFindSearch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Services
{
    public interface ICustomerDataService
    {
        Task<IEnumerable<Customer>> SearchCustomers(string searchText);
        Task<Customer> GetCustomer(int customerId);
    }
}
