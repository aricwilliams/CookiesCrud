using Cookies.Models;
using System.ComponentModel.DataAnnotations;

namespace Cookies.DBServiceLayer
{
    public interface IAdminService
    {
        IEnumerable<AdminCookies> GetAllCookies();
        AdminCookies GetCookieByID(int cookieId);
        //AdminImage GetCookieByPhotoID(int cookieId);
        //IEnumerable<AdminImage> GetAllCookieImages();
        //void CreateCookieImage(AdminImage adminCookiesImage);
        //void DeleteCookieImage(int ID);

        void CreateCookie(AdminCookies adminCookies);
        void DeleteCookie(int cookieID);
        void UpdateRecipe(AdminCookies cookie);
        void Save();
    }
}
