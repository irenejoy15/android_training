using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TEST2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }
    }
}
