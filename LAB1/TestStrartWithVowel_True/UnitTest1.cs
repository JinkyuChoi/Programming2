using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestStrartWithVowel_True
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStrartWithVowel_True()
        {
            string vowelStartWord = "owl";

            bool result = LAB1.Program.StartsWithVowel(vowelStartWord);

            Assert.AreEqual(true, result);
        }
    }
}
