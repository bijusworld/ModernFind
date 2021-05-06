using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Services
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly HttpClient _httpClient;

        public CustomerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        Task<IEnumerable<Customer>> ICustomerDataService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            return await JsonSerializer.DeserializeAsync<Customer>
                (await _httpClient.GetStreamAsync($"api/customer/{customerId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            var customerJson =
                new StringContent(JsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"api/customer/", customerJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Customer>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }
        //public async Task<IEnumerable<Customer>> ICustomerDataService.AddCustomer(HttpContent content)
        //{
        //    //return await JsonSerializer.DeserializeAsync<Customer>
        //    //    (await _httpClient.GetStreamAsync($"api/employee/{customerId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        //}
    }
}
