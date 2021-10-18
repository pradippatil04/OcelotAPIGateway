using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products= new();
        public ProductRepository()
        {
            _products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0001",
                Name = "Lenovo Laptop",
                QuantityInStock = 15,
                UnitPrice = 125000
            });
            _products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0002",
                Name = "DELL Laptop",
                QuantityInStock = 25,
                UnitPrice = 135000
            });

            _products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0003",
                Name = "HP Laptop",
                QuantityInStock = 20,
                UnitPrice = 115000
            });
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(_products);
        }
    }
}
