using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cookies.Models
{
    public class AdminCookies
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        [DisplayName("Upload Yummy Cookie Image")]
        public IFormFile? ImageFile { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Recipe { get; set; }
        public string? Type { get; set; }
    }
}
