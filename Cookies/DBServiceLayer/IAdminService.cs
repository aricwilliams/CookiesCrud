using Cookies.Models;
using System.ComponentModel.DataAnnotations;

namespace Cookies.DBServiceLayer
{
    public interface IAdminService
    {
        IEnumerable<AdminCookies> GetAllCookies();
        AdminCookies GetCookieByID(int cookieId);
        void CreateCookie(AdminCookies adminCookies);
        void DeleteCookie(int cookieID);
        void UpdateRecipe(AdminCookies cookie);
        void Save();
    }
}
