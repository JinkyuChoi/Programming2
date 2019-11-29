using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Catalog
    {
        private List<Product> _list = new List<Product>();

        public void Add(Product product)
        {
            _list.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _list;
        }
        public IEnumerable<Product> GetProducts(string filter)
        {
            IEnumerable<Product> products = _list
                .Where(l => l.Name.ToUpper().Contains(filter.ToUpper()));

            List<Product> result = new List<Product>(products);
            return result;
        }
    }
}
