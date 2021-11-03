using AutoMapper;
using OrdersService.Dtos;
using OrdersService.Models;

namespace OrdersService.Profiles
{
    public class OrdersProfile : Profile
    {
        public OrdersProfile()
        {
            CreateMap<Order, OrderReadDto>();
            CreateMap<OrderCreateDto, Order>();
        }
    }
}