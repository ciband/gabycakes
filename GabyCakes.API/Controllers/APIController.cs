using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GabyCakes.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api")]
    public class APIController : Controller
    {
        [HttpGet("products")]
        public IEnumerable<string> GetProducts()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("taxonomies")]
        public IEnumerable<string> GetTaxonomies()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("product/{id}")]
        public string GetProduct(int id)
        {
            return "value";
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
