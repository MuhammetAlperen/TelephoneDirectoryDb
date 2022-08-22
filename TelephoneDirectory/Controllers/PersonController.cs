using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Entityes;

namespace TelephoneDirectory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
