using Cookies.Data;
using Cookies.DBServiceLayer;
using Cookies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;



namespace Cookies.Controllers
{
    public class CookiesRecipesController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CookiesRecipesController(IAdminService adminService, IWebHostEnvironment webHostEnvironment)
        {
            _adminService = adminService;
            _webHostEnvironment = webHostEnvironment;
        }

        public ActionResult Index()
        {
            var cookies = from cookie in _adminService.GetAllCookies()
                        select cookie;
            return View(cookies);
        }
        public ViewResult GetRecipe(int id)
        {
            AdminCookies recipe = _adminService.GetCookieByID(id);
            return View(recipe);
        }

        public ActionResult CreateRecipe()
        {
            return View(new AdminCookies());
        }
        [HttpPost]
        public ActionResult CreateRecipe(AdminCookies cookie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cookie.GetCookiePhotoFile();
                    _adminService.CreateCookie(cookie);
                    _adminService.Save();
                    return RedirectToAction("Index", "CookiesRecipes");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "oh no! The cookie monster is near...Try Again");
            }
            return View(cookie);
        }


        public ActionResult Edit(int id)
        {
            AdminCookies recipe = _adminService.GetCookieByID(id);
            return View(recipe);
        }
        [HttpPost]
        public ActionResult Edit(AdminCookies cookie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //AdminCookies recipe = _adminService.GetCookieByID(cookie.Id);
                    //cookie.CookiePhoto = recipe.CookiePhoto;
                    cookie.GetCookiePhotoFile();
                    _adminService.UpdateRecipe(cookie);
                    _adminService.Save();
                    return RedirectToAction("Index", "CookiesRecipes");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. I think you made an error");
            }
            return View(cookie);
        }



        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again.";
            }
            AdminCookies recipe = _adminService.GetCookieByID(id);
            return View(recipe);
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        public ActionResult DeleteConfirmed(int id, bool? saveChangesError)
        {
            try
            {
                AdminCookies cookies = _adminService.GetCookieByID(id);
                if (cookies == null)
                {
                    return RedirectToAction("Index");
                }
                _adminService.DeleteCookie(id);
                _adminService.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", "CookiesRecipes");
            }
            return RedirectToAction("Index");
        }
    }
}
