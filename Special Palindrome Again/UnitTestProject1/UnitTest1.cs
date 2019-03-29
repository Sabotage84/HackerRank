using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp21;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12,Program.substrCount(8,"mnonopoo"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(7, Program.substrCount(5, "asasd"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(10, Program.substrCount(7, "abcbaba"));
        }
    }
}
