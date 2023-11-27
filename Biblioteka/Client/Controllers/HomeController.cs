using Client.Models;
using CommonLibrary;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.ServiceFabric.Services.Remoting.Client;

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
            ViewBag.AvailableBooks = "";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Validate(FormModel model)
        {
            try
            {
                IValidator proxy = ServiceProxy.Create<IValidator>(new Uri("fabric:/Biblioteka/Validator"));
                TempData["Result"] = await proxy.Validate(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Result"] = "Error in communication with service " + ex.Message;
                return RedirectToAction("Index");
            }

        }
   
        public async Task<ActionResult<Book>> ValidateBook(string bookID, double price, string name, string writterName, int quantity)
        {
            try
            {
                IBookStore proxy = ServiceProxy.Create<IBookStore>(new Uri("fabric:/Biblioteka/BookStore"));
                Book b = new Book(bookID, price, name, writterName, quantity);
                List<Book> books = new List<Book>();
                books = await proxy.ListAvailableItem();
                ViewBag.AvailableBooks = books;
                ViewBag.ItemPrice = await proxy.GetItemPrice(bookID);
              
                return View();
            }

            catch (Exception ex)
            {
                ViewBag.Result = "Error in communication with service " + ex.Message;
                return RedirectToAction("Privacy");
            }
        }

    }
}

