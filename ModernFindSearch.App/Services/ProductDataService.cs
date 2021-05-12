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
    public class ProductDataService : IProductDataService
    {
        private readonly HttpClient _httpClient;

        public ProductDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Product>>
                (await _httpClient.GetStreamAsync($"api/product"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<Product>> GetAllProducts(string filter)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Product>>
                (await _httpClient.GetStreamAsync($"api/product/{filter}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<Product>> PostAllProductsFilter(ProductFilter filter)
        {

            var body = new StringContent(JsonSerializer.Serialize(filter), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/product", body);

            if (response.IsSuccessStatusCode)
            {
                //return await JsonSerializer.DeserializeAsync<IEnumerable<Product>>
                //    (await _httpClient.GetStreamAsync($"api/product/{filter}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                var content = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<IEnumerable<Product>>(content);
            }

            return null;
        }

    }
}
