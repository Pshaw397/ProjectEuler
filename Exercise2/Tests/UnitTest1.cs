using NUnit.Framework;
using Exercise2;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (4000000, 4613732)]
        [TestCase(25000, 14328)]
        public void FibonacciTests(int testNum, int expected)
        {
            int result = Program.Fib(testNum);
            Assert.AreEqual(expected, result);
        }
    }
}