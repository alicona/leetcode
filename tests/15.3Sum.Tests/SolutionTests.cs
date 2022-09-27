using NUnit.Framework;
using System.Collections.Generic;

namespace _15._3Sum.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
    public void Test1(int[] nums, IList<IList<int>> expectedList)
    {
        var result = _sut.ThreeSum(nums);
        Assert.AreEqual(expectedList.Count, result.Count);
    }

    private static IList<IList<int>> CreateResultList(params int[][] nums)
    {
        var mainList = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            var internalArray = nums[i];
            var list = new List<int>();

            for (int j = 0; j < internalArray.Length; j++)
            {
                list.Add(internalArray[j]);
            }
            mainList.Add(list);
        }
        return mainList;
    }

    private static class DataClass
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[]{-1,0,1,2,-1,-4},
                    CreateResultList(new int[]{-1,-1,2}, new int[]{-1,0,1}));
                yield return new TestCaseData(
                    new int[]{0,0,0},
                    CreateResultList(new int[]{0,0,0}));
                yield return new TestCaseData(
                    new int[]{0,0,0,0},
                    CreateResultList(new int[]{0,0,0}));
                yield return new TestCaseData(
                    new int[]{0,1,1},
                    new List<IList<int>>());
                yield return new TestCaseData(
                    new int[]{-2,0,0,2,2},
                    CreateResultList(new int[]{0,0,0}));
                yield return new TestCaseData(
                    new int[]{-2,0,1,1,2},
                    CreateResultList(new int[]{-2,0,2}, new int[]{-2,1,1}));
                
            }
        }
    }
}