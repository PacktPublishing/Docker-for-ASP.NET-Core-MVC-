using Microsoft.AspNetCore.Mvc;

namespace Packt.HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        [Route("/")]
        [HttpGet]
        public string Get()
        {
            return "Hello ASP.NET Core Docker World!";
        }
    }
}
