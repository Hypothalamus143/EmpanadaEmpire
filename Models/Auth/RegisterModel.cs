using System.ComponentModel.DataAnnotations;

namespace EmpanadaEmpire.Models.Auth;

public class RegisterModel
{
    // Section 1: A little about you
    [Required(ErrorMessage = "First name is required")]
    [Display(Name = "First name")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last name is required")]
    [Display(Name = "Last name")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    [Display(Name = "Email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mobile number is required")]
    [Phone(ErrorMessage = "Please enter a valid mobile number")]
    [RegularExpression(@"^(\+63|0)9\d{9}$", ErrorMessage = "Must be a valid Philippine number (+639123456789 or 09123456789)")]
    [Display(Name = "Mobile number")]
    public string MobileNumber { get; set; } = "+63 ";

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [RegularExpression(@"^(?=.*\d).*$", ErrorMessage = "Password must include at least one number")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please confirm your password")]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    public string ConfirmPassword { get; set; } = string.Empty;

    // Section 2: Where should we bring the good stuff?
    [Required]
    public string Country { get; set; } = "Philippines";

    [Required]
    public string City { get; set; } = "Cebu City";

    [Required(ErrorMessage = "Please select your barangay")]
    public string Barangay { get; set; } = string.Empty;

    public string? Landmark { get; set; }

    [Required(ErrorMessage = "House/Unit number and street is required")]
    public string StreetAddress { get; set; } = string.Empty;

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the Terms and Privacy Policy")]
    public bool AgreeToTerms { get; set; }
}