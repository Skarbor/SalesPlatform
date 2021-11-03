using System.Collections.Generic;
using System.Linq;
using OrdersService.Models;

namespace OrdersService.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext _context;

        public OrdersRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders;
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.SingleOrDefault(order => order.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() == 0;
        }
    }
}