
using Core.Entities;
using Core.Interfaces;
using Infrastracure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProduct()
        {
            var products = await _productRepository.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrands()
        {
            var productBrands = await _productRepository.GetProductsBrandsAsync();
            return Ok(productBrands);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductType>>> GetProductType()
        {
            var productTypes = await _productRepository.GetProductsTypesAsync();
            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return Ok(product);
        }
    }
}
