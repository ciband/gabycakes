using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GabyCakes.API.Models;
using GabyCakes.API.Services;

namespace GabyCakes.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api")]
    public class APIController : Controller
    {
        private readonly IProductService _productService;

        public APIController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            return getProducts(_productService.GetProducts);
        }

        [HttpGet("products/cupcakes")]
        public IActionResult GetCupcakes()
        {
            return getProducts(_productService.GetCupcakes);
        }
        [HttpGet("products/cakes")]
        public IActionResult GetCakes()
        {
            return getProducts(_productService.GetCakes);
        }
        [HttpGet("products/brownies")]
        public IActionResult GetBrownies()
        {
            return getProducts(_productService.GetBrownies);
        }
        [HttpGet("products/cookies")]
        public IActionResult GetCookies()
        {
            return getProducts(_productService.GetCookies);
        }

        [HttpGet("taxonomies")]
        public IActionResult GetTaxonomies()
        {
            return getProducts(_productService.GetTaxonomies);
        }

        [HttpGet("product/{id}")]
        public IActionResult GetProduct(int id)
        {
            return getProducts(_productService.GetTaxonomies, NotFound());
        }

        private IActionResult getProducts<T>(Func<T> getProductsFunc) where T : class
        {
            return getProducts(getProductsFunc, NoContent());
        }
        private IActionResult getProducts<T>(Func<T> getProductsFunc, StatusCodeResult result) where T : class
        {
            var products = getProductsFunc();
            if (products != null)
            {
                return Ok(products);
            }
            return result;
        }

        // POST api/values
        /*[HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
