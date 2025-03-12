using Shared.Persistence.Models;
using AuthService.Models;

namespace NotificationService.Models;

public class Notification : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Message { get; set; }
    public NotificationType Type { get; set; }
    public DateTime NotificationDate { get; set; }
}

public enum NotificationType
{
    OrderPlaced,
    OrderShipped,
    PaymentSuccess,
    PaymentFailed
}