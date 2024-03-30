using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "Index Title";
            List<Person> people = new List<Person>()
            {
               new Person() { Name = "Hassan", BirthDate = Convert.ToDateTime("2010-02-08"), PersonGender = Gender.Male},
               new Person() { Name = "Ali", BirthDate = Convert.ToDateTime("2000-07-08") , PersonGender = Gender.Female},
               new Person() { Name = "Ahmed", BirthDate = Convert.ToDateTime("1999-02-05"), PersonGender = Gender.Other }
            };
            ViewData["people"] = people;
            /*
             * by default, it will look for a view named Index,
               in a folder named Views then subfolder named Home
             */
            return View(); 
        }
    }
}
