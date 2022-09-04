namespace _21.MergeTwoSortedLists.Tests;

public class SolutionTests
{
    private Solution _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
    public void ShouldMergeTwoSortedLinkedLists(ListNode list1, ListNode list2, ListNode expected)
    {
        var result = _sut.MergeTwoLists(list1, list2);

        while(result != null || expected != null)
        {
            Assert.NotNull(result);
            Assert.NotNull(expected);
            Assert.AreEqual(expected.val, result.val);
            result = result.next;
            expected = expected.next;
        }
    }

    private static ListNode CreateList(List<int> numbers)
    {
        ListNode prevNode = null;
        ListNode node = null;

        for (int i = numbers.Count()-1; i >= 0; i--)
        {
            node = new ListNode(numbers[i], prevNode);
            prevNode = node;
        }

        return node;
    }

    private static class DataClass
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
                {
                    yield return new TestCaseData(
                        CreateList(new List<int> {1,2,3}), 
                        CreateList(new List<int>()), 
                        CreateList(new List<int> {1,2,3}));
                    yield return new TestCaseData(
                        CreateList(new List<int>()), 
                        CreateList(new List<int>{4,5,6}), 
                        CreateList(new List<int> {4,5,6}));
                    yield return new TestCaseData(
                        CreateList(new List<int>{1}),
                        CreateList(new List<int> {2}),
                        CreateList(new List<int>{1,2}));
                    yield return new TestCaseData(
                        CreateList(new List<int>{2}),
                        CreateList(new List<int> {1}),
                        CreateList(new List<int>{1,2}));
                    yield return new TestCaseData(
                        CreateList(new List<int>{1,2,4}),
                        CreateList(new List<int> {1,3,4}),
                        CreateList(new List<int>{1,1,2,3,4,4}));
                }
        }
    }


}