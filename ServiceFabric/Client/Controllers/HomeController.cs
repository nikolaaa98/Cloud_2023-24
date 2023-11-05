using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CommonLibrary;

namespace Client.Controllers
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

        [HttpPost]
        [Route("/HomeController/Buy")]
        public async Task<IActionResult> Buy(string name, string imePisca, double cena, int godinaProizvodnje)
        {
            Book b = new Book(name, imePisca, cena, godinaProizvodnje);
            BookServiceImplementation service = new BookServiceImplementation();
            if (bool.Parse(service.WriteAllBooks(b).ToString()))
                return View("Index");
            else
                return View("Privacy");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}