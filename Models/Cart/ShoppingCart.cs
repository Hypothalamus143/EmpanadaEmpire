namespace EmpanadaEmpire.Models.Cart;

public class ShoppingCart
{
    public List<CartItem> Items { get; set; } = [];
    public decimal DeliveryFee { get; set; } = 49.00m; // Cebu City flat rate from UI
    public decimal PackagingFee { get; set; } = 0.00m; // "On us"
    public string? KitchenInstructions { get; set; }

    // Computed totals
    public int TotalPieces => Items.Sum(i => i.Quantity);
    public decimal Subtotal => Items.Sum(i => i.Subtotal);
    public decimal Total => Items.Count > 0 ? Subtotal + DeliveryFee + PackagingFee : 0m;

    public string FormattedSubtotal => $"₱{Subtotal:N2}";
    public string FormattedTotal => $"₱{Total:N2}";
    public string FormattedDeliveryFee => DeliveryFee == 0 ? "Free" : $"₱{DeliveryFee:N2}";

    public void AddOrIncrement(CartItem item)
    {
        var existing = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
        if (existing is not null)
        {
            existing.Quantity += item.Quantity;
        }
        else
        {
            Items.Add(item);
        }
    }

    public void DecrementOrRemove(Guid productId)
    {
        var existing = Items.FirstOrDefault(i => i.ProductId == productId);
        if (existing is null) return;

        existing.Quantity--;
        if (existing.Quantity <= 0)
        {
            Items.Remove(existing);
        }
    }

    public void Remove(Guid productId) => Items.RemoveAll(i => i.ProductId == productId);
    public void Clear() => Items.Clear();
}