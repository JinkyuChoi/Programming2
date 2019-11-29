using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - List");
            Console.WriteLine("2 - Queue");
            Console.WriteLine("3 - Stack");
            Console.WriteLine("4 - Dictionary");


            ProductCollection products = null;
            do
            {
                try
                {
                    Console.Write("\nEnter an option: ");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            products = new ProductList();
                            break;
                        case 2:
                            products = new ProductQueue();
                            break;
                        case 3:
                            products = new ProductStack();
                            break;
                        case 4:
                            products = new ProductDictionary();
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
            } while (products == null);

            try
            {
                products.LoadFromFile("productlist.txt");
                products.DisplayProducts();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            try
            {
                Console.Write("\nEnter a number to remove: ");
                int removeNumber = int.Parse(Console.ReadLine());

                products.RemoveProducts(removeNumber);
                products.DisplayProducts();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            try
            {
                Console.Write("\nEnter a number to find: ");
                int findNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Found: {products.FindProduct(findNumber)}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            Console.Write("\npress any key to exit");
            Console.ReadKey();
        }

    }
}
