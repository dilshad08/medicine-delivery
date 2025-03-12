using OrderService.Data;
using OrderService.Models;
using Shared.Persistence.Repositories;

namespace OrderService.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(OrderDbContext context) : base(context) {}
    }
}