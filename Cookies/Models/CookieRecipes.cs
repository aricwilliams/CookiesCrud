using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cookies.Models
{
    public class CookieRecipes
    {
        [Key]
        public string? Id { get; set; }
       
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Recipe { get; set; }
        public string? Type { get; set; }

    }
}
