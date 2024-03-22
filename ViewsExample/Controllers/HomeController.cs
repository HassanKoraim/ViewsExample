using Microsoft.AspNetCore.Mvc;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            /*
             * by default, it will look for a view named Index,
               in a folder named Views then subfolder named Home
             */
            return View(); 
        }
    }
}
