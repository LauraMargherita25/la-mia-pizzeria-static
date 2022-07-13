using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Array array;
            List<Pizza> pizzaList = new List<Pizza>();

            pizzaList.Add(new Pizza("Margherita Static", "lorem ipsum", "img/margherita.jpg", 5));
            pizzaList.Add(new Pizza("Capricciosa Static", "lorem ipsum", "img/margherita.jpg", 5));
            pizzaList.Add(new Pizza("Marinara Static", "lorem ipsum", "img/margherita.jpg", 5));

            array = pizzaList.ToArray();

            ViewBag.PizzaList = array;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

