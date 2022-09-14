namespace _3.LongestSubstring;

/// <summary>
/// Given a string s, find the length of the longest substring 
/// without repeating characters.
/// </summary>
public class Solution
{
    public int LengthOfLongestSubstring(string s) 
    {
        var longest = 0;
        var dictionary = new Dictionary<char,int>();

        for (int i = 0, j =0; i < s.Length; ++i)
        {
            if(dictionary.ContainsKey(s[i]))
            {
                j = Math.Max(j, dictionary.GetValueOrDefault(s[i]) + 1);
                dictionary.Remove(s[i]);
            }

            dictionary.Add(s[i], i);
            longest = Math.Max(longest, i - j+1);
            
        }

        return longest;
    }
}
