namespace _5.LongestPalindromicSubstring;
/// <summary>
/// Given a string s, return the longest palindromic substring in s.
/// A string is called a palindrome string if the reverse of that string
/// is the same as the original string.
/// 
/// Constraints:
///     1 <= s.length <= 1000
///     s consist of only digits and English letters.
/// </summary>
public class Solution
{
    public string LongestPalindrome(string s)
    {
        if(s.Length == 1) return s;

        string longest = string.Empty;
        
        for (int i = 0; i < s.Length; i++)
        {
            var s1 = OddCheck(i, s);
            Console.WriteLine($"ODD: {s1} => {i}");
            var s2 = EvenCheck(i, s);
            Console.WriteLine($"EVEN: {s2} => {i}");

            if(s1.Length > longest.Length) longest = s1;
            if(s2.Length > longest.Length) longest = s2;
            Console.WriteLine($"LONG: {longest}");
        }
        
        return longest;
    }

    private string OddCheck(int middle, string s)
    {
        // First element, no elements to the left
        if(middle == 0) return s[0].ToString();
        int right = middle + 1;
        int left = middle - 1;

        while(right < s.Length && left >= 0)
        {
            if(s[left] == s[right]) 
            {
                right++;
                left--;
                continue;
            }

            break;
        }

        return s.Substring(left + 1, right- (left + 1));
    }

    private string EvenCheck(int middle, string s)
    {
        // Last element no elements to the right.
        if(middle == s.Length - 1) return s[middle].ToString();

        int right = middle + 1;
        int left = middle;
        
        while(right < s.Length && left >= 0)
        {
            if(s[left] == s[right]) 
            {
                right++;
                left--;  
                continue;
            }

            break;
        }

        return s.Substring(left + 1, right- (left + 1));
    }
}
