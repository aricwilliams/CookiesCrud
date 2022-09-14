using Cookies.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cookies.Controllers
{
    public class AccountContoller : Controller
    {
        private readonly ApplicationDbContext _db;
        public AccountContoller(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
