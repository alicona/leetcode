namespace _268.MissingNumber.Tests;

public class MissingNumberTests
{
    private Solution? _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[] {3,0,1}, 2)]
    [TestCase(new int[] {0,1}, 2)]
    [TestCase(new int[] {9,6,4,2,3,5,7,0,1}, 8)]
    public void Should_ReturnMissingNumberFromArray(int[] nums, int expected)
    {
        var result = _sut.MissingNumber(nums);

        Assert.AreEqual(expected, result);
        //Assert.Pass();
    }
}