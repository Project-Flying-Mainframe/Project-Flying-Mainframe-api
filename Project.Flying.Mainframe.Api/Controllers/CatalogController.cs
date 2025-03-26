using Microsoft.AspNetCore.Mvc; 
using Project.Flying.Mainframe.Domain.Catalog; 

namespace Project.Flying.Mainframe.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase {
        [HttpGet]
        public IActionResult GetItems() {
            return Ok("Hello World.");
        }

    }
}