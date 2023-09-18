
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastracure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IGenericRepository<Products> _productRepository;
        private readonly IGenericRepository<ProductBrand> _productBrandRepository;
        private readonly IGenericRepository<ProductType> _productTypeRepository;
        public ProductController(IGenericRepository<Products> productRepository, IGenericRepository<ProductBrand> productBrandRepository, IGenericRepository<ProductType> productTypeRepository)
        {
            _productRepository = productRepository;
            _productBrandRepository = productBrandRepository;
            _productTypeRepository = productTypeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProduct()
        {
            var spec = new ProductWithTypeAndBrendSpecification();
            var products = await _productRepository.ListAsync(spec);
            return Ok(products);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrands()
        {
            var productBrands = await _productBrandRepository.ListAllAsync();
            return Ok(productBrands);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductType>>> GetProductType()
        {
            var productTypes = await _productTypeRepository.ListAllAsync();
            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var spec = new ProductWithTypeAndBrendSpecification(id);
            var product = await _productRepository.GetEntityWithSpec(spec);
            return Ok(product);
        }
    }
}
