using AutoMapper;
using ProductsService.Dtos;
using ProductsService.Models;

namespace ProductsService.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}