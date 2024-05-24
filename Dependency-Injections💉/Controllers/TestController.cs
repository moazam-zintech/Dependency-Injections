using Dependency_Injections_.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injections_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IRandomNumberGen _random;
        public TestController(IRandomNumberGen random)
        {
            _random = random;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var responce=_random.GetRandomNumber();
            return Ok(responce);
        }
    }
}
