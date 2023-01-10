using System.ComponentModel.DataAnnotations;

namespace RefreshTokenDemo.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "The Password field must be at least 5 characters.")]
        public string? Password { get; set; }
    }
}
