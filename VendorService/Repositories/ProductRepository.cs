using VendorService.Data;
using InventoryService.Models;
using Shared.Persistence.Repositories;

namespace InventoryService.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(VendorDbContext context) : base(context) {}
    }
}