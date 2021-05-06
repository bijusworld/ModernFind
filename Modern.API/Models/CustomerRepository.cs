using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern.API.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public Customer AddCustomer(Customer customer)
        {
            var addedEntity = _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }
    }
}
