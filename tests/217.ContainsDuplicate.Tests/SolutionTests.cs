using NUnit.Framework;

namespace _217.ContainsDuplicate.Tests
{
    [TestFixture]
    public class ContainsDuplicateTests
    {
        private Solution _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Solution();
        }

        [TestCase(new int[] {1,2,3,1}, true)]
        [TestCase(new int[] {5,2,3,1,5}, true)]
        [TestCase(new int[] {1,1,1,3,3,4,3,2,4,2}, true)]
        [TestCase(new int[] {1,2,3,4}, false)]
        [TestCase(new int[] {5,7,9,1,3}, false)]
        [TestCase(new int[] {11,13,15}, false)]
        public void Should_returnTrueWhenDuplicate(int[] nums, bool expected)
        {
            // Arrange / Act
            var result = _sut.ContainsDuplicate(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
