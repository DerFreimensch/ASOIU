using System.ComponentModel.DataAnnotations;

namespace ASOIU.Models.ViewModels;

public class UserViewModel
{
    public class RegisterViewModel : User
    {
        [Required]
        [Display(Name = "Фамилия")]
        public string surname { get; set; } 
        
        [Required]
        [Display(Name = "Имя")]
        public string name { get; set; } 
        
        [Display(Name = "Фамилия")]
        public string sec_name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        public int req_day { get; set; }
        
        [Required]
        [Display(Name = "Почта")]
        public string email { get; set; }
                
        [Required]
        [Display(Name = "Логин")]
        public string login { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string password { get; set; }
 
        [Required]
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string passwordConfirm { get; set; }
        
        
    }
}