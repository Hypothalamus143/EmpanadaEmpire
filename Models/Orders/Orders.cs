using EmpanadaEmpire.Models.Enums;
using EmpanadaEmpire.Models.Location;

namespace EmpanadaEmpire.Models.Orders;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string OrderNumber { get; set; } = $"EE-{DateTime.UtcNow:yyyyMMdd}-{Random.Shared.Next(1000, 9999)}";
    public Guid UserId { get; set; }

    // Snapshot of customer details at time of order
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;
    public DeliveryAddress DeliveryAddress { get; set; } = new();

    public List<OrderItem> Items { get; set; } = [];
    public decimal Subtotal { get; set; }
    public decimal DeliveryFee { get; set; } = 49.00m;
    public decimal PackagingFee { get; set; } = 0.00m;
    public decimal TotalAmount { get; set; }

    public string? KitchenInstructions { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Received;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string DeliveryTimeEstimate => "30–45 min";
}