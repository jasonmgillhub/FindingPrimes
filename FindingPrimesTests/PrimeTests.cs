using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftSource_Test
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void TestNegativePrime()
        {
            var res = FindingPrimes.Program.IsPrimeNumber(-1);

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestPrime2()
        {
            var res = FindingPrimes.Program.IsPrimeNumber(2);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestPrime7()
        {
            var res = FindingPrimes.Program.IsPrimeNumber(7);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestPrime29()
        {
            var res = FindingPrimes.Program.IsPrimeNumber(29);

            Assert.IsTrue(res);
        }
    }
}
