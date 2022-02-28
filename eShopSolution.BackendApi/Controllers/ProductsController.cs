using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;

        public ProductsController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await _publicProductService.GetAll();
            return Ok(product);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
