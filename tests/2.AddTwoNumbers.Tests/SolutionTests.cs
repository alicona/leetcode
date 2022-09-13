using NUnit.Framework;
using System.Collections.Generic;

namespace _2.AddTwoNumbers.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
    public void ShouldSumTwoLinkedLists(ListNode l1, ListNode l2, ListNode expected)
    {
        var result = _sut.AddTwoNumbers(l1, l2);
        
        while(expected!= null)
        {
            Assert.AreEqual(expected.val, result.val);
            expected = expected.next;
            result= result.next;
        }
    }

    private static ListNode CreateList(List<int> numbers)
    {
        ListNode prevNode = null;
        ListNode node = null;

        for (int i = numbers.Count -1; i >= 0; i--)
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
                        CreateList(new List<int> {2,4,3}), 
                        CreateList(new List<int>{5,6,4}), 
                        CreateList(new List<int> {7,0,8}));
                    yield return new TestCaseData(
                        CreateList(new List<int> {0}), 
                        CreateList(new List<int>{0}), 
                        CreateList(new List<int> {0}));
                    yield return new TestCaseData(
                        CreateList(new List<int> {9,9,9,9,9,9,9}), 
                        CreateList(new List<int>{9,9,9,9}), 
                        CreateList(new List<int> {8,9,9,9,0,0,0,1}));
                }
        }
    }
}