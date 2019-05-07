using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp10;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 204619;
            string[] arStr = File.ReadAllLines("test1.txt");
            int[] arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Assert.AreEqual(43253, Program.pairs(k, arr));
        }
    }
}
