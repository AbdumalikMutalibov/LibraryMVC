using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Name = "Sariq devni minib",
                Author = "X.To'xtaboyev",
                Price = 25000
            },
            new Book
            {
                Id = 2,
                Name = "Sariq devni minib2",
                Author = "X.To'xtaboyev",
                Price = 30000
            },
            new Book
            {
                Id = 3,
                Name = "Sariq devni minib3",
                Author = "X.To'xtaboyev",
                Price = 35000
            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult Book()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            books.Add(book);
            return RedirectToAction("index");
        }
    }
}