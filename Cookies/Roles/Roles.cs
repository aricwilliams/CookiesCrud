using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cookies.Roles
{
    public class Roles
    {
        public static string Admin = "Admin";
        public static string Customer = "Customer";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Roles.Admin,Text=Roles.Admin}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Roles.Customer,Text=Roles.Customer},
                };
            }
        }
    }
}
