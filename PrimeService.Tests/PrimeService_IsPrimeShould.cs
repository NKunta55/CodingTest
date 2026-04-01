using Xunit;
using Prime.Services;
using PrimeServiceType = Prime.Services.PrimeService;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeServiceType();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs2_ReturnTrue()
        {
            var primeService = new PrimeServiceType();
            bool result = primeService.IsPrime(2);

            Assert.True(result, "2 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var primeService = new PrimeServiceType();
            bool result = primeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs0_ReturnFalse()
        {
            var primeService = new PrimeServiceType();
            var result = primeService.IsPrime(0);

            Assert.False(result, "0 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIsNegative_ReturnFalse()
        {
            var primeService = new PrimeServiceType();
            var result = primeService.IsPrime(-5);

            Assert.False(result, "-5 should not be prime");
        }

        [Fact]
        public void IsPrime_OddCompositeNumber_ReturnFalse()
        {
            var primeService = new PrimeServiceType();
            var result = primeService.IsPrime(9);

            Assert.False(result);
        }
    }
}