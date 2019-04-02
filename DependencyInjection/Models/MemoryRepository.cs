using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository : IRepository
    {
        private Dictionary<string, Product> _products;

        public MemoryRepository()
        {
            _products = new Dictionary<string, Product>();
            new List<Product>
            {
                new Product{Name="Kite",Price=275m},
                new Product{Name="Lifejacket",Price=48.95m},
                new Product{Name="Soccerball",Price=19.5m},
            }.ForEach(p=>AddProduct(p));
        }
        public IEnumerable<Product> Products => _products.Values;
        public Product this[string name] => _products[name];

        public void AddProduct(Product product)=>
             _products[product.Name] = product;


        public void DeleteProduct(Product product)=>
            _products.Remove(product.Name);


    }
}
