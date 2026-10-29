using System.ComponentModel.DataAnnotations;

namespace EmpanadaEmpire.Models.Auth;

public class LoginModel
{
    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    [Display(Name = "Email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = string.Empty;

    public bool RememberMe { get; set; }
}