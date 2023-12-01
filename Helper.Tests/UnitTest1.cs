using System.Text;

namespace Helper.Tests
{
    public class UnitTest1
    {
        /*
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new JasonUtilities.Helper();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
        */

        private readonly JasonUtilities.Helper _primeService;

        public UnitTest1()
        {
            _primeService = new JasonUtilities.Helper();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData("jsn",123)]
        [InlineData("test",456)]
        [InlineData("boo",333)]
        public void HelperMethod1_2TestSets_ReturnProperString(string value, int expected)
        {
            var result = JasonUtilities.Helper.HelperMethod1(value, expected);

            var shouldBe = string.Format("{0}_{1}.txt",value,expected);

            Assert.Equal(shouldBe, result);
        }
    }
}