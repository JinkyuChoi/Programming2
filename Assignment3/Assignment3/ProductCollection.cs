using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    public abstract class ProductCollection
    {
        public int Count { get; }

        public abstract void AddProduct(Product product);
        public abstract void DisplayProducts();
        public abstract Product FindProduct(int id);
        public void LoadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                for (int i = 0; !reader.EndOfStream; i++)
                { 
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    float price = float.Parse(parts[2]);

                    Product product = new Product(id, name, price);
                    AddProduct(product);
                }      
            };  
        }
        public abstract void RemoveProducts(int number);

    }
}
