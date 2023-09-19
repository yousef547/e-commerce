
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using e_commerce.Api.Dtos;
using Infrastracure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace e_commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {

        private readonly IGenericRepository<Products> _productRepository;
        private readonly IGenericRepository<ProductBrand> _productBrandRepository;
        private readonly IGenericRepository<ProductType> _productTypeRepository;
        private readonly IMapper _mapper;
        public ProductController(IGenericRepository<Products> productRepository, IGenericRepository<ProductBrand> productBrandRepository, IGenericRepository<ProductType> productTypeRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _productBrandRepository = productBrandRepository;
            _productTypeRepository = productTypeRepository;
            _mapper=mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductToReturnDto>>> GetProduct()
        {
            var spec = new ProductWithTypeAndBrendSpecification();
            var products = await _productRepository.ListAsync(spec);

            return Ok(_mapper.Map<IReadOnlyList<Products>, IReadOnlyList<ProductToReturnDto>>(products));
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
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var spec = new ProductWithTypeAndBrendSpecification(id);
            var product = await _productRepository.GetEntityWithSpec(spec);
            return _mapper.Map<Products, ProductToReturnDto>(product);
        }
    }
}
