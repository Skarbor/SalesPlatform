using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsService.Data;
using ProductsService.Dtos;
using ProductsService.Models;

namespace ProductsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductsRepository _productsRepository;
        private IMapper _mapper;

        public ProductsController(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddProduct(ProductCreateDto productToCreate)
        {
            Console.WriteLine("Attempt to create product " + productToCreate.Name);

            _productsRepository.AddProduct(_mapper.Map<Product>(productToCreate));
            _productsRepository.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IEnumerable<ProductReadDto> GetProducts()
        {
            return _mapper.Map<IEnumerable<ProductReadDto>>(_productsRepository.GetAllProducts());
        }

        [HttpGet]
        [Route("{productId}")]
        public IActionResult GetProductById(int productId)
        {
            var product = _productsRepository.GetProductById(productId);

            if(product is null) 
                return NotFound();

            return Ok(_mapper.Map<ProductReadDto>(product));
        }
    }
}