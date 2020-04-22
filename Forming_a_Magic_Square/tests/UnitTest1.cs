using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forming_a_Magic_Square;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckMatrixGoodMatrixs()
        {
            int[][] s1 =
                {
                    new int[] { 1, 1, 1},
                    new int[] { 1, 1, 1},
                    new int[] { 1, 1, 1}
                };

            Assert.AreEqual(true, Program.CheckMatrix(s1));

            int[][] s2 =
                {
                    new int[] { 4, 9, 2},
                    new int[] { 3, 5, 7},
                    new int[] { 8, 1, 6}
                };

            Assert.AreEqual(true, Program.CheckMatrix(s2));


        }
        [TestMethod]
        public void TestCheckMatrixbadMatrix()
        {
            int[][] s1 =
                {
                    new int[] { 1, 1, 1},
                    new int[] { 1, 9, 1},
                    new int[] { 1, 1, 1}
                };

            Assert.AreEqual(false, Program.CheckMatrix(s1));
        }
    }
}
