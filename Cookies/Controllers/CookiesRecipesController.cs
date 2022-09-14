using Cookies.Data;
using Cookies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookies.Controllers
{
    public class CookiesRecipesController :Controller
    {
        private readonly ApplicationDbContext _db;
        public CookiesRecipesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CookieRecipes> objList = _db.CookieRecipies;
            return View(objList);
        }
    }
}
