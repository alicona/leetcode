namespace _724.FindPivotIndex.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[]{1,7,3,6,5,6}, 3)]
    [TestCase(new int[]{1,2,3}, -1)]
    [TestCase(new int[]{2,1,-1}, 0)]
    [TestCase(new int[]{-1,-1,-1,-1,-1,0}, 2)]
    public void Should_returnPivotIndex(int[] nums, int expected)
    {
        var result = _sut.PivotIndex(nums);
        Assert.AreEqual(expected, result);
    }
}