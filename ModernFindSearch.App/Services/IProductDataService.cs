using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModernFindSearch.App.Services
{
    public interface IProductDataService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetAllProducts(string filter);
        Task<IEnumerable<Product>> PostAllProductsFilter(ProductFilter filter);
    }
}
