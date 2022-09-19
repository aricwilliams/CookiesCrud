using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Cookies.Models
{
    public class AdminCookies
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Recipe { get; set; }
        public string? Type { get; set; }
        [Display(Name = "Choose the recipe image!")]
        //[Required, Microsoft.Web.Mvc.FileExtensions(Extensions = "csv", ErrorMessage = "cookies/images")]
        [NotMapped]
        public IFormFile? CookiePhotoFile { get; set; }
        public byte[]? CookiePhoto { get; set; }
        public void GetCookiePhotoFile()
        {
            if (CookiePhotoFile != null)
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CookiePhotoFile.CopyTo(memoryStream);
                    CookiePhoto = memoryStream.ToArray();
                }
        }
    }

}
