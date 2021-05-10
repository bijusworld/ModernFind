using Microsoft.AspNetCore.Mvc;
using Modern.API.Models;
using ModernFindSearch.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Modern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer customer { get; set; } = new Customer();
        public IEnumerable<Customer> customers { get; set; }
        private readonly ICustomerRepository _customerRepository;

        private List<Customer> _customers = new List<Customer> {
            new Customer {CustomerId = 1, CustomerCategory = CustomerCategory.B2B, CustomerName = "XYZ Business Ltd.", Street = "Elvis Lane", PostCode = "TW16", City = "London"},
            new Customer {CustomerId = 2, CustomerCategory = CustomerCategory.B2C, CustomerName = "ABC Informatics Ltd.", Street = "Bankers street", PostCode = "TW03", City = "Cardiff"},
            new Customer {CustomerId = 3, CustomerCategory = CustomerCategory.B2B, CustomerName = "The Bus Company", Street = "Bankers street", PostCode = "TW05", City = "London"},
            new Customer {CustomerId = 4, CustomerCategory = CustomerCategory.B2C, CustomerName = "TBC Company", Street = "Bankers street", PostCode = "TW15", City = "Birmingham"},
            new Customer {CustomerId = 5, CustomerCategory = CustomerCategory.B2B, CustomerName = "Nice Silks", Street = "Bankers street", PostCode = "TW05", City = "London"},
            new Customer {CustomerId = 6, CustomerCategory = CustomerCategory.B2B, CustomerName = "Lipton tea", Street = "Thames bank", PostCode = "TW05", City = "London"},
            new Customer {CustomerId = 7, CustomerCategory = CustomerCategory.B2C, CustomerName = "August Company", Street = "Deal curve", PostCode = "TW05", City = "London"},
            new Customer {CustomerId = 8, CustomerCategory = CustomerCategory.B2B, CustomerName = "The Bus two Company", Street = "Bankers street", PostCode = "TW05", City = "Luton"},
        };

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customerRepository.GetAllCustomers());
        }

        [HttpGet("{id:int}")]
        public Customer GetCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.CustomerId == id);
            return customer;
        }

        [HttpPost]
        public string SearchCustomers([FromBody] string searchText)
        {
            customers = _customers.Where(c => c.CustomerName.ToLower().Contains(searchText.ToLower()));
            var searchResultJson = JsonSerializer.Serialize(customers);
            return searchResultJson;
        }
    }
}
