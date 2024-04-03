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
            return View(people); 
        }
        [Route("person-details/{name}")]
        public IActionResult Details(string name)
        {
            if(name == null)
            {
                return Content("Person name can't be null");
            }
            List<Person>? people = new List<Person>()
            {
               new Person() { Name = "Hassan", BirthDate = Convert.ToDateTime("2010-02-08"), PersonGender = Gender.Male},
               new Person() { Name = "Ali", BirthDate = Convert.ToDateTime("2000-07-08") , PersonGender = Gender.Female},
               new Person() { Name = "Ahmed", BirthDate = Convert.ToDateTime("1999-02-05"), PersonGender = Gender.Other }
            };
            Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
            return View(matchingPerson);
        }
        [Route("person-with-products")]
        public IActionResult PersonWithProudcts()
        {
            Person person = new Person()
            {
                Name = "Hassan",
                BirthDate = Convert.ToDateTime("2010-02-08"),
                PersonGender = Gender.Male
            };
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Laptop"
            };
            PersonAndProductWrapperClass personAndProductWrapperClass = new PersonAndProductWrapperClass()
            {
                PersonData = person,
                ProductData = product
            };
            return View("PersonAndProduct", personAndProductWrapperClass);
        }
        [Route("Home/all-products")]
        public IActionResult All()
        {
            return View();
            //Views/Home/All.cshtml
            //Views/Shared/All.cshtml  
        }
    }
}
