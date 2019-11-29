using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ProductList : ProductCollection
    {
        private List<Product> _products;

        public int Count { get { return _products.Count; } }

        public override void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public override void DisplayProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"{product}");
            }
        }
        public override Product FindProduct(int id)
        {
            Product resultProduct = null;
            foreach (Product product in _products)
            {
                if (product.ID == id)
                {
                    resultProduct = product;
                }
            }
            return resultProduct;

        }
        public ProductList()
        {
            _products = new List<Product>();
        }
        public ProductList(Product[] products)
        {      
            _products = new List<Product>(products);
        }
        public override void RemoveProducts(int number)
        {
            _products.RemoveAt(number);
        }
    }
}
