using Microsoft.EntityFrameworkCore;
using InventoryService.Models;

namespace VendorService.Data
{
    public class VendorDbContext : DbContext
    {
        public VendorDbContext(DbContextOptions<VendorDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}