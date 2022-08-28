namespace _392.IsSubsequence.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    [TestCase("aa", "ahbadc", true)]
    [TestCase("acb", "ahbgdc", false)]
 
    public void ShouldCheckIfItIsSubstring(string s, string t, bool expected)
    {
        var result = _sut.IsSubsequence(s, t);
        Assert.AreEqual(expected, result);
    }
}