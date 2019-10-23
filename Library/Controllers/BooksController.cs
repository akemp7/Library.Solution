using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Library.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly LibraryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public BooksController(UserManager<ApplicationUser> userManager, LibraryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(_db.Genres, "GenreId", "Name");
            ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "LastName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book, int GenreId, int AuthorId)
        {
            _db.Books.Add(book);
            if (GenreId != 0)
            {
                _db.BookGenre.Add(new BookGenre() { GenreId = GenreId, BookId = book.BookId });
            }

            if (AuthorId != 0)
            {
                _db.BookAuthor.Add(new BookAuthor() { AuthorId = AuthorId, BookId = book.BookId });
            }

            _db.SaveChanges();
            return RedirectToAction("Index", "Account");
        }

    }
}