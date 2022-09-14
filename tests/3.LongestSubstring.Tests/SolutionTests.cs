using NUnit.Framework;

namespace _3.LongestSubstring.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("babbb", 2)]
    [TestCase("pwwkew", 3)]
    [TestCase("dvdf", 3)]
    [TestCase("advdfg", 4)]
    [TestCase("abcdecgh", 5)]
    public void ShouldReturnLongestSubstring(string s, int expected)
    {
        var result = _sut.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, result);
    }
}