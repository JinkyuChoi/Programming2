using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ProductDictionary : ProductCollection
    {
        private Dictionary<int,Product> _products;

        public int Count { get { return _products.Count; } }

        public override void AddProduct(Product product)
        {
            _products.Add(product.ID, product);
        }
        public override void DisplayProducts()
        {
            foreach (var product in _products )
            {
                Console.WriteLine($"{product}");
            }
        }
        public override Product FindProduct(int id)
        {
            Product resultProduct = null;
            foreach (var product in _products)
            {
                if (product.Key == id)
                {
                    resultProduct = product.Value;
                }
            }
            return resultProduct;
        }
        public ProductDictionary()
        {
            _products = new Dictionary<int, Product>();
        }
        public ProductDictionary(Product[] products)
        {
            foreach (Product product in products)
            {
                _products = new Dictionary<int, Product>()
                {
                    { product.ID, product }
                };
            }
        }
        public override void RemoveProducts(int number)
        {
            _products.Remove(number);
        }
    }
}
