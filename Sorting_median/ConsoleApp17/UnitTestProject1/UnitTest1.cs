using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ConsoleApp17;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int d = 10000;
            
            string path = @"test.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            var arr = Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r =  Program.activityNotifications(arr, d);
            Assert.AreEqual(633, r);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int d = 9999;
           
            string path = @"test2.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            var arr = Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = Program.activityNotifications(arr, d);
            Assert.AreEqual(770, r);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int d = 10122;
            
            string path = @"test3.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            var arr = Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = Program.activityNotifications(arr, d);
            Assert.AreEqual(1026, r);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int d = 30000;

            string path = @"test4.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            var arr = Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = Program.activityNotifications(arr, d);
            Assert.AreEqual(492, r);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int d = 40001;

            string path = @"test5.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            var arr = Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = Program.activityNotifications(arr, d);
            Assert.AreEqual(926, r);
        }
    }
}
