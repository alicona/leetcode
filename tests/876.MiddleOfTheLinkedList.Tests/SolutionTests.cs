using System.Collections.Generic;
using NUnit.Framework;

namespace _876.MiddleOfTheLinkedList.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCaseSource(typeof(DataClass), nameof(DataClass.TestCases))]
    public void ShouldReturnTheMiddleOfTheLinkedList(ListNode input, int expected)
    {
        var result = _sut.MiddleNode(input);
        Assert.AreEqual(expected, result.val);
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
                yield return new TestCaseData(CreateList(new List<int> {1,2,3,4,5}), 3 );
                yield return new TestCaseData(CreateList(new List<int> {1,2,3,4,5,6}), 4 );
                yield return new TestCaseData(CreateList(new List<int> {1,2}), 2 );
                yield return new TestCaseData(CreateList(new List<int> {1}), 1 );
            }
        }
    } 
}