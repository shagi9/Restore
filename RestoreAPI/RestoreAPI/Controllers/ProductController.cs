using Microsoft.AspNetCore.Mvc;
using Restore.BLL.Dtos;
using Restore.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await productService.GetProducts();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
