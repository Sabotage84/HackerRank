using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HalloweenSale;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, Program.howManyGames(20, 3, 6, 80));
        }
    }
}
