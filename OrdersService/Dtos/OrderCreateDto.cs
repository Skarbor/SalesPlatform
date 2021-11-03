using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Dtos
{
    public class OrderCreateDto
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public string ShipmentDetails { get; set; }
    }
}