using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var book1 = new Book();
            book1.Title = "Atlas Shrugged";
            book1.Author = "Ayn Rand";
            book1.NumberOfPages = 1168;

            return View(book1);
        }
    }
}
