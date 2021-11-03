using System.Collections.Generic;
using OrdersService.Models;

namespace OrdersService.Data
{
    public interface IOrdersRepository
    {
        Order GetOrderById(int id); 
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order order);
        bool SaveChanges();
    }
}