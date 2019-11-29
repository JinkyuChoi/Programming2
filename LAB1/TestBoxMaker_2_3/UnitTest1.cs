using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBoxMaker_2_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBoxMaker_2_3()
        {

            int width = 3;
            int height = 3;

            string result = LAB1.Program.BoxMaker(width, height);

            Assert.AreEqual("***\n* *\n***\n", result);
        }
    }
}
