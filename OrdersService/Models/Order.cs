using System.ComponentModel.DataAnnotations;

namespace OrdersService.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]  
        public int Count { get; set; }

        [Required]
        public string ShipmentDetails { get; set; }
    }
}