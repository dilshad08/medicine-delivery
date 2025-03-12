namespace Shared.Persistence.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }  // Use UUID (Guid) for primary key
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }  // Using UUID for user IDs
        public Guid? UpdatedBy { get; set; }
    }
}