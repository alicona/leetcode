namespace _136.SingleNumber.Tests;

public class SingleNumberTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[] {2,2,1}, 1)]
    [TestCase(new int[] {4,1,2,1,2}, 4)]
    [TestCase(new int[] {1}, 1)]
    public void ShouldReturnNumberThatIsNotDuplicated(int[] nums, int expected)
    {
        var result = _sut.SingleNumber(nums);
        Assert.AreEqual(expected, result);
    }
}