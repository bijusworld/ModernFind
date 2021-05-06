using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modern.API.Models;
using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private List<Customer> _customers = new List<Customer> {
                new Customer {CustomerId = 1, CustomerCategory = CustomerCategory.B2B, CustomerName = "XYZ Business Ltd.", Street = "Elvis Lane", PostCode = "TW16", City = "London"},
                new Customer {CustomerId = 2, CustomerCategory = CustomerCategory.B2C, CustomerName = "ABC Informatics Ltd.", Street = "Bankers street", PostCode = "TW03", City = "London"},
        };
        public Customer Customer { get; set; } = new Customer();
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customerRepository.GetAllCustomers());
        }

        [HttpGet("{customerId:int}")]
        public Customer GetCustomer(int customerId)
        {
            //return _customers.Where(c => c.CustomerId == customerId);
            //return Ok(_customerRepository.GetCustomerById(id));
            Customer = _customers.FirstOrDefault(c => c.CustomerId == customerId);
            return Customer;

        }


        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            if (customer == null)
                return BadRequest();

            if (customer.CustomerName == string.Empty)
            {
                ModelState.AddModelError("Name", "The company name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdCustomer = _customerRepository.AddCustomer(customer);

            return Created("customer", createdCustomer);
            //var createdCustomer = customer;
            //return customer;
        }
    }
}
