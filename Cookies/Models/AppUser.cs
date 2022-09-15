using Microsoft.AspNetCore.Identity;

namespace Cookies.Models
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }    
    }
}

//example of how i would customize ASP.Net users table
//Identity is a default implementation from Microsoft, out of the box code that adds fields to our database
//we want to be able to track the name of users, so we made this model and gave a field of "Name" so this 
//so this will add a column of name in the ASP.NetUsers table in the database... this class inherits from IdentityUser.
//see https://docs.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-6.0 -> "CUSTOM USERDATA PART"
