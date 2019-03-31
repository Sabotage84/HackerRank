using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3,Program.commonChild("ABCD", "ABDC"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, Program.commonChild("HARRY", "SALLY"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, Program.commonChild("SHINCHAN", "NOHARAAA"));
        }
    }
}
