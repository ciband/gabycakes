using GabyCakes.API.Models;
using System.Collections.Generic;

namespace GabyCakes.API.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<string> GetTaxonomies();
        Product GetProduct(int id);
        IEnumerable<Product> GetCupcakes();
        IEnumerable<Product> GetBrownies();
        IEnumerable<Product> GetCakes();
        IEnumerable<Product> GetCookies();
    }
}