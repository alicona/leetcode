namespace _70.ClimbingStairs;
public class Solution
{
    public int ClimbStairs(int n)
    {
        if(n < 4) return n;

        var prev = 3;
        var prevprev = 2;
        var total = 0;

        for (int i = 4; i <= n; i++)
        {
            total = prev + prevprev;

            prevprev = prev;
            prev = total;
        }

        return total;
        
    }
}
