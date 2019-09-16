using NUnit.Framework;
using candys;

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
            Assert.AreEqual(3, Program.minimumPasses(3, 1, 2, 12));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(16, Program.minimumPasses(1, 1, 6, 45));
        }
    }
}