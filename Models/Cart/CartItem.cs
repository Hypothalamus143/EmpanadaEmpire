using EmpanadaEmpire.Models.Catalog;

namespace EmpanadaEmpire.Models.Cart;

public class CartItem
{
    public Guid ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }

    public decimal Subtotal => UnitPrice * Quantity;
    public string FormattedUnitPrice => $"₱{UnitPrice:N0}";
    public string FormattedSubtotal => $"₱{Subtotal:N0}";

    public static CartItem FromProduct(Product product, int quantity = 1) => new()
    {
        ProductId = product.Id,
        Name = product.Name,
        Description = product.Description,
        ImageUrl = product.ImageUrl,
        UnitPrice = product.Price,
        Quantity = quantity
    };
}