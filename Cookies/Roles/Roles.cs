using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cookies.Roles
{
    public class Roles
    {
        public static string Admin = "Admin";
        public static string Customer = "Customer";

        public static List<SelectListItem> GetRolesForDropDown()
        {

            return new List<SelectListItem>
            {
                new SelectListItem{Value = Roles.Admin,Text=Roles.Admin},
                new SelectListItem{Value = Roles.Admin,Text=Roles.Customer}
            };


        }
    }
}
