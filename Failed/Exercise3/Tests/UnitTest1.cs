using NUnit.Framework;
using Exercise3;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LargestPrimeNumOf13195()
        {
            Assert.AreEqual(29, Program.primeNumEx());
        }
    }
}