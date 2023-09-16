
using Core.Entities;
using Infrastracure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
                _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProduct()
        {
            var products = await _context.products.ToListAsync();
            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var product = await _context.products.FindAsync(id);
            return product;
        }
    }
}
