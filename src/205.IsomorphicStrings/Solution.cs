namespace _205.IsomorphicStrings;
public class Solution
{
    public bool IsIsomorphic(string s, string t) 
    {
        var dict01 = new Dictionary<char, char>();
        var dict02 = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            // if(s[i] == t[i]) return false;

            if(!dict01.TryAdd(s[i], t[i]))
            {
                dict01.TryGetValue(s[i], out var o);
                if(o != t[i]) return false;
            }

            if(!dict02.TryAdd(t[i], s[i]))
            {
                dict02.TryGetValue(t[i], out var o);
                if(o != s[i]) return false;
            }
        }

        return true;
    }
}
