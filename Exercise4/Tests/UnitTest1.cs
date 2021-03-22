using NUnit.Framework;
using Exercise4;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (10, 100, 9009)]
        public void Test1(int minNum, int maxNum, int expected)
        {
            Assert.Contains(9009, Program.Pal(minNum, maxNum));
        }
    }
}