using NUnit.Framework;

namespace _4.MedianTwoSortedArrays.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase(new int[]{1,3}, new int[]{2}, 2.0)]
    [TestCase(new int[]{1,2}, new int[]{3,4}, 2.5)]
    [TestCase(new int[]{4}, new int[]{}, 4.0)]
    [TestCase(new int[]{1}, new int[]{3}, 2.0)]
    public void ShouldReturnMedianOfTwoSortedArrays(int[] nums1, int[] nums2, double expected)
    {
        var result = _sut.FindMedianSortedArrays(nums1, nums2);
        Assert.AreEqual(expected, result);
    }
}