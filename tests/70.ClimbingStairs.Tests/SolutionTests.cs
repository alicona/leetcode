namespace _70.ClimbingStairs.Tests;

[TestFixture]
public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(1,1)]
    [TestCase(2,2)]
    [TestCase(3,3)]
    [TestCase(4,5)]
    [TestCase(5,8)]
    [TestCase(6,13)]
    public void ShouldReturnDistinctWaysToClimb(int n, int expected)
    {
        var result = _sut.ClimbStairs(n);
        Assert.AreEqual(expected, result);
    }
}