using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment4
{
    public static class DataStore
    {
        public static Catalog Load(string filePath)
        {
            Catalog catalog = new Catalog();
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int i = 0; !reader.EndOfStream; i++)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    Product product = new Product()
                    {
                        Department = (EDepartment)Enum.Parse(typeof(EDepartment), parts[0]),
                        Name = parts[1],
                        Price = decimal.Parse(parts[2])
                    };
                    catalog.Add(product);
                }
            };
            return catalog;
        }
        public static void Save(Catalog catalog, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                IEnumerable<Product> list = catalog.GetAllProducts();
                foreach(Product product in list)
                {
                    writer.WriteLine($"{product.Department},{product.Name},{product.Price}");
                }
            };
        }
    }
}
