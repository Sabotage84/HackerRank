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
            Assert.AreEqual(0, Program.minimumPasses(0, 0, 0, 0));
        }
    }
}