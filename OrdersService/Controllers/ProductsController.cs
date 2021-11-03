using System;
using Microsoft.AspNetCore.Mvc;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpPost]
        public IActionResult ProductCreated(int productId)
        {
            Console.WriteLine($"Product with id {productId} created");
            return Ok();
        }
    }
}