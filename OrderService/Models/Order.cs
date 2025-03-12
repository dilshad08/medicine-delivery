using Shared.Persistence.Models;
using VendorService.Models;
using AuthService.Models;

namespace OrderService.Models;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public User Customer { get; set; }
    public Guid VendorId { get; set; }
    public Vendor Vendor { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }
}

public class OrderItem : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public enum OrderStatus
{
    Pending,
    Completed,
    Cancelled,
    Shipped,
}