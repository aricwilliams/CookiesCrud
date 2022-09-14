using System.ComponentModel.DataAnnotations;

namespace Cookies.Models
{
    public class CookieRecipes
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
