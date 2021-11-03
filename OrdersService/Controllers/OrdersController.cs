using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdersService.Data;
using OrdersService.Dtos;
using OrdersService.Models;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;

        public OrdersController(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddOrder(OrderCreateDto orderCreateDto)
        {
            Console.WriteLine($"Attempt to add order for product {orderCreateDto.ProductId}");
            
            _ordersRepository.AddOrder(_mapper.Map<Order>(orderCreateDto));
            _ordersRepository.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var allOrders = _ordersRepository.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(allOrders));
        }

        [HttpGet]
        [Route("{orderId}")]
        public IActionResult GetOrderById(int orderId)
        {
            var order = _ordersRepository.GetOrderById(orderId);

            if(order is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderReadDto>(order));
        }
    }
}