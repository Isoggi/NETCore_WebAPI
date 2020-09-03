using Microsoft.AspNetCore.Mvc;

namespace WebAPI.NETCoreTest.Controllers
{
    [Route("")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public ContentResult Index()
        {
            //private string Login =
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<div>Hello World</div>"
            };
        }
    }
}
