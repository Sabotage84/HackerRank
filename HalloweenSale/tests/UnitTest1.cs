using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HalloweenSale;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(6, Program.howManyGames(20, 3, 6, 80));
        }
        [TestMethod]
        public void TestM2()
        {
            Assert.AreEqual(9917, Program.howManyGames(16, 2, 1, 9981));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(0, Program.howManyGames(100, 1, 1, 99));
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(1, Program.howManyGames(100, 19, 1, 180));
        }
        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(3905, Program.howManyGames(99, 3, 1, 5555));
        }


    }
}
