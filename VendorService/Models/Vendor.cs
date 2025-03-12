using Shared.Persistence.Models;

namespace VendorService.Models;

public class Vendor : BaseEntity
{
    public string VendorName { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public ICollection<Medicine> Medicines { get; set; }
}

public class Medicine : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public Guid VendorId { get; set; }
    public Vendor Vendor { get; set; }
}