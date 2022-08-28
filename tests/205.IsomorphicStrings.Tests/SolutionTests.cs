namespace _205.IsomorphicStrings.Tests;

public class SolutionTests
{
    private Solution _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Solution();
    }

    [TestCase("egg","add", true)]
    [TestCase("foo","bar", false)]
    [TestCase("paper","title", true)]
    [TestCase("badc","baba", false)]
    public void ShouldCheckIfItIsomorphicString(string s, string t, bool expected)
    {
        var result = _sut.IsIsomorphic(s,t);
        Assert.AreEqual(expected, result);
    }
}