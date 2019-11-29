using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLAB3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LAB3Test()
        {
            string manufacturer = "KIA";
            string model = "Carnival";
            int year = 2017;
            decimal basePrice = 5000;
            decimal price;
            LAB3.Colour colour = LAB3.Colour.White;
            LAB3.Package package = LAB3.Package.Standard;

            LAB3.Car car = new LAB3.Car(manufacturer, model, year, basePrice, colour, package);
            price = car.GetFullPrice();

            Assert.AreEqual(manufacturer, car.Manufacturer);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(year, car.Year);
            Assert.AreEqual(price, car.Price);
        }
    }
}
