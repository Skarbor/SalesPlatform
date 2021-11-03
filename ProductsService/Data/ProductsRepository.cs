using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsService.Models;

namespace ProductsService.Data
{
    public class ProductsRepository : IProductsRepository
    {
        private AppDbContext _context;

        public ProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.SingleOrDefault(product => product.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}