
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController
    {

        private readonly StoreContext _context;

        public ProductsController(StoreContext context)

        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
             return await _context.Products.ToListAsync();

            //return Ok(products);
        }

        /*private ActionResult<List<Product>> Ok(List<Product> products)
        {
            throw new NotImplementedException();
        }*/

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            return _context.Products.Find(id);
        }
    }
}