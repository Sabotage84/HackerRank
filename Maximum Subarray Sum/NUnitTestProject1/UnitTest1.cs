using NUnit.Framework;
using ConsoleApp1;
using System.IO;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            long[] arr = { 1, 5, 9 };
            long M = 5;
            Assert.AreEqual(4, Program.maximumSum(arr, M));
        }
        [Test]
        public void Test6()
        {
            long[] arr = {  9,3, 3, 9, 5 };
            long M = 7;
            Assert.AreEqual(6, Program.maximumSum(arr, M));
        }

        [Test]
        public void Test7()
        {
            long[] arr = { 1, 1, 1, 1, 1,3,3 };
            long M = 7;
            Assert.AreEqual(6, Program.maximumSum(arr, M));
        }


        [Test]
        public void Test2()
        {

            long M = 1804289384;
            string[] arStr;
            long[] arr;
            arStr = File.ReadAllLines("test2.txt");
            arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            Assert.AreEqual(1802192837, Program.maximumSum(arr, M));
        }
        [Test]
        public void Test3()
        {

            long M = 184803527;
            string[] arStr;
            long[] arr;
            arStr = File.ReadAllLines("test3.txt");
            arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            Assert.AreEqual(184770427, Program.maximumSum(arr, M));
        }

        [Test]
        public void Test4()
        {

            long M = 2104194685;
            string[] arStr;
            long[] arr;
            arStr = File.ReadAllLines("test4.txt");
            arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            Assert.AreEqual(2104190778, Program.maximumSum(arr, M));
        }

        [Test]
        public void BigTest()
        {
            int q = 10000;

            string[] allstr = File.ReadAllLines("bigtest.txt");
            string[] allres = File.ReadAllLines("bigtestresults.txt");

            for (int qItr = 0, i = 0; qItr < allstr.Length; qItr += 2, i++)
            {
                string[] nm = allstr[qItr].Split(' ');

                int n = Convert.ToInt32(nm[0]);

                long m = Convert.ToInt64(nm[1]);

                long[] a = Array.ConvertAll(allstr[qItr + 1].Split(' '), aTemp => Convert.ToInt64(aTemp));
                long result = Program.maximumSum(a, m);
                long expRes = Convert.ToInt64(allres[i]);
                Assert.AreEqual(expRes, result);
                Console.WriteLine(expRes == result);
            }
        }

        [Test]
        public void Test5()
        {

            long M = 2040651435;
            string[] arStr;
            long[] arr;
            arStr = File.ReadAllLines("test5.txt");
            arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            Assert.AreEqual(2040332872, Program.maximumSum(arr, M));
        }



        [Test]
        public void SuperBigTest()
        {
            int q = 50;

            string[] allstr = File.ReadAllLines("Sbigtest.txt");
            string[] allres = File.ReadAllLines("Sbigtestresults.txt");

            for (int qItr = 0, i = 0; qItr < allstr.Length; qItr += 2, i++)
            {
                string[] nm = allstr[qItr].Split(' ');

                int n = Convert.ToInt32(nm[0]);

                long m = Convert.ToInt64(nm[1]);

                long[] a = Array.ConvertAll(allstr[qItr + 1].Split(' '), aTemp => Convert.ToInt64(aTemp));
                long result = Program.maximumSum(a, m);
                long expRes = Convert.ToInt64(allres[i]);
                Assert.AreEqual(expRes, result);
                Console.WriteLine(expRes == result);
            }
        }
    }
}