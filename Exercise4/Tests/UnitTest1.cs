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
        [TestCase(100, 1000, 906609)]
        public void PalindromeTests(int minNum, int maxNum, int expected)
        {
            Assert.AreEqual(expected, Program.Pal(minNum, maxNum));
        }
    }
}