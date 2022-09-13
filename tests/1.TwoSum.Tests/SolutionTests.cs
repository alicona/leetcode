using NUnit.Framework;

namespace _1.TwoSum.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[]{2,7,11,15}, 9, new int[]{0,1})]
    [TestCase(new int[]{3,2,4}, 6, new int[]{1,2})]
    [TestCase(new int[]{3,3}, 6, new int[]{0,1})]
    [TestCase(new int[]{1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11, new int[]{5,11})]
    public void Test1(int[] nums, int target, int[] expected)
    {
        var result = _sut.TwoSum(nums, target);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(expected[i], result[i]);
        }
    }
}
