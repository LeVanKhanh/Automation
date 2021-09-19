using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Selenium.Models;
using System.Diagnostics;

namespace Selenium.Controllers
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Error", new ErrorViewModel());
            }
            if (loginViewModel.Name == "guest" && loginViewModel.Password == "guest")
            {
                return RedirectToAction("Index");
            }
            return View("Error", new ErrorViewModel());
        }
    }
}
