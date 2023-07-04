using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim alanı boş geçilemez.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı boş geçilemez.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez.")]
        [Compare("Password", ErrorMessage = "Şifreleriniz uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
