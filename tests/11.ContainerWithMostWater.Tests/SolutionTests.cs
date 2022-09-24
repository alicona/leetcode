using NUnit.Framework;

namespace _11.ContainerWithMostWater.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[]{1,8,6,2,5,4,8,3,7}, 49)]
    [TestCase(new int[]{1,1}, 1)]
    [TestCase(new int[]{2,1, 3}, 4)]
    public void ShouldReturnContainerWithMostWater(int[] height, int expected)
    {
        var result = _sut.MaxArea(height);

        Assert.AreEqual(expected, result);
    }
}