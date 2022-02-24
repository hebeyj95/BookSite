using BookSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static BookSite.Models.BookRepository;
using BookSite.Models.ViewModels;

namespace BookSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //private BookstoreContext context { get; set; }
        //public HomeController(BookstoreContext books)
        //        {
        //            context = books;
        //        }


        private IBookRepository repo;
        public HomeController(IBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNumber = 1)
        {

            int pageSize = 5;
            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNumber
                }
            };

            return View(x);
        }

    }
}
