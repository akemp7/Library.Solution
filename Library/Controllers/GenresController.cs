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
    public class GenresController : Controller
    {
        private readonly LibraryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public GenresController(UserManager<ApplicationUser> userManager, LibraryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index(int GenreId)
        {
            System.Console.WriteLine(GenreId);
            Genre genre = _db.Genres.FirstOrDefault(g => g.GenreId == GenreId);
            return View(genre);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            _db.Genres.Add(genre);
            _db.SaveChanges();
            return RedirectToAction("Index", "Genres");
        }

        
    }
}