using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestStrartWithVowel_False
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStrartWithVowel_False()
        {
            string consonantStartWord = "city";

            bool result = LAB1.Program.StartsWithVowel(consonantStartWord);

            Assert.AreEqual(false, result);
        }
    }
}
