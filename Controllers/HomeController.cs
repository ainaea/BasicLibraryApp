using BasicLibraryManagementSystem.Models;
using BasicLibraryManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookServices allBookServies;

        public HomeController(ILogger<HomeController> logger, BookServices allBookServies)
        {
            _logger = logger;
            this.allBookServies = allBookServies;
        }

        public IActionResult Index()    
        {
            return View();
        }

        public IActionResult Books()
        {
            return View(allBookServies.GetAllBooks());
        }

        [HttpGet]
        public IActionResult EnterBook()
        {
            return View(new Book());
        }

        [HttpPost]
        public IActionResult EnterBook(Book book)
        {
            Book entry = new Book()
            {
                ISBN = book.ISBN,
                Title = book.Title,
                Author = book.Author,
                CoverPhoto = book.CoverPhoto,
                Edition = book.Edition,
                Publisher = book.Publisher                
            };
            allBookServies.AddBook(entry);
            return RedirectToAction("Books");
        }

        
        public IActionResult SearchBooks()
        {
            return View(new Book());
        }

        
        public IActionResult DisplayBooks(Book book)
        {
            Book choiceBook = allBookServies.GetBook(book.Title);
            return View(choiceBook);
        }

        public IActionResult Book(int id)
        {            
            return View(allBookServies.GetBook(id));
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
