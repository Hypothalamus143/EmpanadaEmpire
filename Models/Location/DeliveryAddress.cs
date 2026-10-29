using System.ComponentModel.DataAnnotations;

namespace EmpanadaEmpire.Models.Location;

public class DeliveryAddress
{
    [Required(ErrorMessage = "Street and house/unit number is required")]
    [Display(Name = "House / unit number, building & street")]
    public string StreetAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Barangay is required")]
    [Display(Name = "Barangay")]
    public string Barangay { get; set; } = string.Empty;

    [Required]
    [Display(Name = "City")]
    public string City { get; set; } = "Cebu City";

    [Required]
    [Display(Name = "Country")]
    public string Country { get; set; } = "Philippines";

    [Display(Name = "Landmark (optional)")]
    public string? Landmark { get; set; }

    // Formatted for checkout header and preview card
    public string SingleLineDisplay =>
        $"{StreetAddress}, Barangay {Barangay}, {City}, {Country}";

    public string ShortLocation => $"{Barangay}, {City}";
}