using NUnit.Framework;
using Exercise6;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (10, 2640)]
        [TestCase (100, 25164150)]
        [TestCase (50, 1582700)]
        public void Test1(int sqaureLimit, int expected)
        {
            Assert.AreEqual(expected, Program.Sum(sqaureLimit));
        }
    }
}