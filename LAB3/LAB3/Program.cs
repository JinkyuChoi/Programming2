using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public enum Colour
    {
        None,
        Red,
        Black,
        White,
        Silver
    }

    public enum Package
    {
        Standard,
        Sport,
        Luxury
    }

    public class Car
    {
        private decimal _basePrice;

        public Colour Colour
        {
            get;
            set;
        }

        public string Manufacturer
        {
            get;
        }

        public string Model
        {
            get;
        }
        
        public Package Package
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
        }

        public int Year
        {
            get;
        }

        public Car(string maufacturer, string model, int year, decimal basePrice, Colour colour, Package package)
        {
            Manufacturer = maufacturer;
            Model = model;
            Year = year;
            _basePrice = basePrice;
            Colour = colour;
            Package = package;
            Price = GetPackagePrice() + GetPaintPrice() + _basePrice;
        }

        private decimal GetPackagePrice()
        {
            decimal packagePrice = 0;

            Package package = Package;
            if(package == Package.Standard)
            {
                packagePrice = 0;
            }
            else if(package == Package.Sport)
            {
                packagePrice = 2000;
            }
            else if (package == Package.Luxury)
            {
                packagePrice = 5000;
            }

            return packagePrice;
        }

        private decimal GetPaintPrice()
        {
            decimal paintPrice = 0;

            Colour colour = Colour;
            if (colour == Colour.Black || colour == Colour.White)
            {
                paintPrice = 100;
            }
            else if (colour == Colour.Silver)
            {
                paintPrice = 250;
            }
            else if (colour == Colour.Red)
            {
                paintPrice = 500;
            }

            return paintPrice;
        }

        public decimal GetFullPrice()
        {
            decimal fullPrice = GetPackagePrice() + GetPaintPrice() + _basePrice;
            return fullPrice;  
        }

        public override string ToString()
        {
            return string.Format("Manufacturer = {0} Model = {1} Year = {2} BasePrice = {3}", Manufacturer, Model, Year, _basePrice);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
