using NUnit.Framework;

namespace _13.RomanToInteger.Tests
{
    [TestFixture]
    public class RomanToIntegerTests
    {
        private Solution _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Solution();
        }

        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void Should_ConvertRomantToInteger(string s, int expected)
        {
            var result = _sut.RomanToInteger(s);
            Assert.AreEqual(expected, result);
        }
    }
}