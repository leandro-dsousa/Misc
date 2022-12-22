using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpPost]
        [Route("1")]
        public string post_1()
        {
            return "post_1 works";
        }
    }
}
