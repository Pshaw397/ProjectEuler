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

        [TestCase (10, 23)]
        [TestCase(1000, 233168)]
        public void SumOfMultiplesUpTo10(int multiple, int expected)
        {
            Program programObj = new Program();
            int result = programObj.MultiplesOf(multiple);
            Assert.AreEqual(expected, result);
        }
    }
}