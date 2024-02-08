using API.Data;
using API.EntitiesModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        [HttpPost]
        public string CreateProduct()
        {

            return "";
        }

        [HttpPost("Id")]
        public string UpdateProduct(int id)
        {
            return "";
        }

        [HttpDelete("Id")]
        public void DeleteProduct(int id)
        {

        }
    }
}
