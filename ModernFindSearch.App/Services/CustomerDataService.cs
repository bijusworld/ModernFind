using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ModernFindSearch.App.Services
{
    public class CustomerDataService : ICustomerDataService
    {
        private HttpClient _httpClient;

        public CustomerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Customer>> SearchCustomers(string searchText)
        {
            var searchJson = new StringContent(System.Text.Json.JsonSerializer.Serialize(searchText), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/customer", searchJson);

            if (response.IsSuccessStatusCode)
            {
                return await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<Customer>>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            return await System.Text.Json.JsonSerializer.DeserializeAsync<Customer>
                (await _httpClient.GetStreamAsync($"api/customer/{customerId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
