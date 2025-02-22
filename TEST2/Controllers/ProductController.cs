using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEST2.Models;

namespace TEST2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       
        private static readonly List<Product> _products = new List<Product>() { 
            new Product
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Price = 100.45m,
                Stock = 100,
                SKU = "SKU1"
            },
            new Product
            {
                Id = 2,
                Name = "Test2",
                Description = "Test2",
                Price = 200.45m,
                Stock = 200,
                SKU = "SKU2"
            },
            new Product
            {
                Id = 3,
                Name = "Test3",
                Description = "Test3",
                Price = 300.45m,
                Stock = 300,
                SKU = "SKU3"
            }
        };
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _products.ToArray();
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
