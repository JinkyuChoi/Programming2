using System;
using Assignment3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignment3
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void ProductListAddTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductList productList = new ProductList();

            productList.AddProduct(testProduct);
            Assert.AreEqual(testProduct,productList.FindProduct(id));
        }

        [TestMethod]
        public void ProductListRemoveTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductList productList = new ProductList();

            productList.AddProduct(testProduct);
            productList.RemoveProducts(0);

            Assert.AreEqual(null, productList.FindProduct(id));
        }

        [TestMethod]
        public void ProductQueueAddTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductQueue productQueue = new ProductQueue();

            productQueue.AddProduct(testProduct);

            Assert.AreEqual(testProduct, productQueue.FindProduct(id));
        }

        [TestMethod]
        public void ProductQueueRemoveTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductQueue productQueue = new ProductQueue();

            productQueue.AddProduct(testProduct);
            productQueue.RemoveProducts(1);

            Assert.AreEqual(null, productQueue.FindProduct(id));
        }

        [TestMethod]
        public void ProductStackAddTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductStack productStack = new ProductStack();

            productStack.AddProduct(testProduct);

            Assert.AreEqual(testProduct, productStack.FindProduct(id));
        }

        [TestMethod]
        public void ProductStackRemoveTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductStack productStack = new ProductStack();

            productStack.AddProduct(testProduct);
            productStack.RemoveProducts(1);

            Assert.AreEqual(null, productStack.FindProduct(id));
        }

        [TestMethod]
        public void ProductDictionaryAddTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductDictionary productDictionary = new ProductDictionary();

            productDictionary.AddProduct(testProduct);

            Assert.AreEqual(testProduct, productDictionary.FindProduct(id));
        }

        [TestMethod]
        public void ProductDictionaryRemoveTest()
        {
            int id = 100;
            string name = "test";
            float price = 100.00f;

            Product testProduct = new Product(id, name, price);
            ProductDictionary productDictionary = new ProductDictionary();

            productDictionary.AddProduct(testProduct);
            productDictionary.RemoveProducts(id);

            Assert.AreEqual(null, productDictionary.FindProduct(id));
        }
    }
}
