using System.ComponentModel.DataAnnotations;

namespace TraverselProject.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınız giriniz.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
