using Microsoft.AspNetCore.Mvc;
using MultipleCheckboxModelbinding.Models;
using System.Diagnostics;

namespace MultipleCheckboxModelbinding.Controllers
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
            return RedirectToAction(nameof(ModelBindingTest));

        }

        public IActionResult ModelBindingTest()
        {
            TestModel model = new()
            {
                Title = "Just testing",
                Price = 9.99,
                Categories = new()
                {
                    new Category { CategoryId = 1, CategoryName = "Action" },
                    new Category { CategoryId = 2, CategoryName = "Comedy" },
                    new Category { CategoryId = 3, CategoryName = "Horror" }
                }
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ModelBindingTest(TestModel m)
        {
            var checkedCategoriesIds = Request.Form["category"];
            foreach (string? category in checkedCategoriesIds)
            {

            }
            return RedirectToAction(nameof(Index));
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}