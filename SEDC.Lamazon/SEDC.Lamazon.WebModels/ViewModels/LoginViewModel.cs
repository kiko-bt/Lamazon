using System.ComponentModel.DataAnnotations;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please insert username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please insert password")]
        public string Password { get; set; }
    }
}