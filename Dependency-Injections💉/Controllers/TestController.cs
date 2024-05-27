using Dependency_Injections_.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Dependency_Injections_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IRandomNumberGen _random1;
        private readonly IRandomNumberGen _random2;

        public TestController(IRandomNumberGen random, IRandomNumberGen random2)
        {
            _random1 = random;

            _random2 = random2;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var responce=new { V=_random1.GetRandomNumber(),
                               C=_random2.GetRandomNumber()};

            
            //var responce=_random1.GetRandomNumber();
            return Ok(responce);
        }
    }
}
