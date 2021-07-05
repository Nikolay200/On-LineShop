using OnlineShopWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Areas.Account.Models
{
    public class ChangePassword
    {
        [Required(ErrorMessage = "Имя пользователя не указано")]        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Пароль должен содержать от 6 до 10 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Пароль должен содержать от 6 до 10 символов")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
