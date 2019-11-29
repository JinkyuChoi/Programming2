using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ProductStack : ProductCollection
    {
        private Stack<Product> _products;

        public int Count { get { return _products.Count; }}

        public override void AddProduct(Product product)
        {
            _products.Push(product);
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
        public ProductStack()
        {
            _products = new Stack<Product>();
        }
        public ProductStack(Product[] products)
        {
            _products = new Stack<Product>(products);
        }
        public override void RemoveProducts(int number)
        {
            for (int i = 0; i < number; i++)
            {
                _products.Pop();
            }
        }
    }
}
