using NUnit.Framework;
using Exercise1;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumOfMultiplesUpTo10()
        {
            Program programObj = new Program();
            int result = programObj.MultiplesOf(10);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void SumOfMultiplesUpTo1000()
        {
            Program programObj = new Program();
            int result = programObj.MultiplesOf(1000);
            Assert.AreEqual(233168, result);
        }
    }
}