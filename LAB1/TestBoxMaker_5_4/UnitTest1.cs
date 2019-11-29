using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBoxMaker_5_4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBoxMaker_5_4()
        {

            int width = 5;
            int height = 4;

            string result = LAB1.Program.BoxMaker(width, height);

            Assert.AreEqual("*****\n*   *\n*   *\n*****\n", result);
        }
    }
}
