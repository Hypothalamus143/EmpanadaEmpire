using EmpanadaEmpire.Models.Location;

namespace EmpanadaEmpire.Models.Auth;

public class UserProfile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public DeliveryAddress DefaultAddress { get; set; } = new();

    public string FullName => $"{FirstName} {LastName}".Trim();

    // Initials for the top-right header badge (e.g. "MS")
    public string Initials
    {
        get
        {
            var f = !string.IsNullOrWhiteSpace(FirstName) ? FirstName[0].ToString() : "";
            var l = !string.IsNullOrWhiteSpace(LastName) ? LastName[0].ToString() : "";
            return $"{f}{l}".ToUpper();
        }
    }
}