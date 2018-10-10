using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "Hello word";
        }

        [HttpPost]
        [Route("")]
        public string Post()
        {
            return "Hello word";
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return "Hello word";
        }
        
        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "Hello word";
        }
    }
}
