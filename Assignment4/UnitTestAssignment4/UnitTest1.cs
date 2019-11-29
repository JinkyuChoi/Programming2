using System;
using System.Collections.Generic;
using System.Linq;
using Assignment4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignment4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CatalogAddTest()
        {
            EDepartment department = EDepartment.Electronics;
            string name = "Playstation";
            decimal price = 400;


            Product testProduct = new Product()
            {
                Name = name,
                Department = department,
                Price = price
            };
            Catalog testCatalog = new Catalog();

            testCatalog.Add(testProduct);
            Assert.IsTrue(testCatalog.GetAllProducts().Contains(testProduct));
        }
        [TestMethod]
        public void CatalogGetProductsTest()
        {
            EDepartment department = EDepartment.Electronics;
            string name = "Playstation";
            decimal price = 400;


            Product testProduct = new Product()
            {
                Name = name,
                Department = department,
                Price = price
            };
            Catalog testCatalog = new Catalog();

            testCatalog.Add(testProduct);
            Assert.IsTrue(testCatalog.GetProducts("Playstation").Contains(testProduct));
        }
    }
}
