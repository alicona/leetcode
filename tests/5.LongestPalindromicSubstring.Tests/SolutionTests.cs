using NUnit.Framework;

namespace _5.LongestPalindromicSubstring.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase("babad", "bab")]
    [TestCase("a", "a")]
    [TestCase("ab", "a")]
    [TestCase("qwtdcbabcdrstumn", "dcbabcd")]
    [TestCase("cbbd", "bb")]
    [TestCase("bb", "bb")]
    [TestCase("werasddsaptl", "asddsa")]
    [TestCase("abcdefg", "a")]
    public void ShouldReturnLongestPalindromicString(string s, string expected)
    {
        var result = _sut.LongestPalindrome(s);

        Assert.AreEqual(expected, result);
    }
}