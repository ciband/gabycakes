using GabyCakes.API.Data;
using GabyCakes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabyCakes.API.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products = new List<Product>();

        public InMemoryProductService()
        {
            _products = DBInitializer.Initialize();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IEnumerable<string> GetTaxonomies()
        {
            return Enum.GetNames(typeof(Category));
        }

        public Product GetProduct(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetCupcakes()
        {
            return _products.Where(p => p.Category == Category.Cupcakes);
        }

        public IEnumerable<Product> GetBrownies()
        {
            return _products.Where(p => p.Category == Category.Brownies);
        }

        public IEnumerable<Product> GetCakes()
        {
            return _products.Where(p => p.Category == Category.Cakes);
        }

        public IEnumerable<Product> GetCookies()
        {
            return _products.Where(p => p.Category == Category.Cookies);
        }
    }
}
