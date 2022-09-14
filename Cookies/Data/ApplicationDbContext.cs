using Cookies.Models;
using Microsoft.EntityFrameworkCore;

namespace Cookies.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CookieRecipes> CookieRecipies { get; set; }

    }
}
