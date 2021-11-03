using System;
using System.Collections.Generic;
using ProductsService.Models;

namespace ProductsService.Data
{
    public interface IProductsRepository
    {
        Product GetProductById(int id); 
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        bool SaveChanges();
    }
}