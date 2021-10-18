using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Product
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Code{ get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
