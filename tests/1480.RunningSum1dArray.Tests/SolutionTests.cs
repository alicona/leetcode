namespace _1480.RunningSum1dArray.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
    public void Should_returnRunningSum(int[] nums, int[] expected)
    {
        var result =_sut.RunningSum(nums);
        Assert.AreEqual(expected, result);
    }

    private class DataClass
        {
            public static IEnumerable<TestCaseData> TestCases 
            {
                get
                {
                    yield return new TestCaseData(new int[] {1,2,3,4}, new int[] {1,3,6,10});
                    yield return new TestCaseData(new int[] {1,1,1,1,1}, new int[] {1,2,3,4,5});
                    yield return new TestCaseData(new int[] {3,1,2,10,1}, new int[] {3,4,6,16,17});
                }
            }
        }
}