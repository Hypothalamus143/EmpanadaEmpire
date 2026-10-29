using EmpanadaEmpire.Models.Enums;

namespace EmpanadaEmpire.Models.Catalog;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public ProductCategory Category { get; set; } = ProductCategory.SavoryFavorites;
    public ProductBadge Badge { get; set; } = ProductBadge.None;
    public bool IsAvailable { get; set; } = true;

    // Helper for displaying Philippine Peso symbol
    public string FormattedPrice => $"₱{Price:N0}";
}