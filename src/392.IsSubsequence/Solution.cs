namespace _392.IsSubsequence;
public class Solution
{
    public bool IsSubsequence(string s, string t) 
    {
        var start = -1;
        for (int i = 0; i < s.Length; i++)
        {
            start = Contains(s[i], t, start + 1);

            if(start == -1) return false;
        }

        return true;
    }

    public int Contains(char s, string t, int start)
    {
        var found = start;
        for (int i = start; i < t.Length; i++)
        {
            if(s == t[i])
            {
                return found;
            }
            found ++;
        }

        return -1;
    }
}
