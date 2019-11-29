using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class ProductEventArgs : EventArgs
    {
        public Product NewProduct { get; }
        public ProductEventArgs(Product product)
        {
            NewProduct = product;
        }
    }
}
