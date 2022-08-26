namespace _448.FindAllNumbersDisappearedInArray.Tests
{
    [TestFixture]
    public class FindAllNumbersDisappearedInArrayTests
    {
        private Solution? _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Solution();
        }

        [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
        public void Should_FindNumbersDissapearedInArray(int[] nums, IList<int> expected)
        {
            Assert.Pass();
        }

        private class DataClass
        {
            public static IEnumerable<TestCaseData> TestCases 
            {
                get
                {
                    yield return new TestCaseData(new int[] {4,3,2,7,8,2,3,1}, new int[] {4,3,2,7,8,2,3,1});
                    yield return new TestCaseData(new int[] {1,1}, new List<int> {2});
                }
            }
        }
    }
}

