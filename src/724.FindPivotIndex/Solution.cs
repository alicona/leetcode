namespace _724.FindPivotIndex;
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var len = nums.Length;
        var left = new int[len];
        left[0] = nums[0];

        for (int i = 1; i < len; i++)
        {
            left[i] = nums[i] + left[i-1];
        }

        for (int i = 0; i < len; i++)
        {
            var right = left[len-1] - left[i] + nums[i];
            if(left[i] == right) return i;
        }
       
        return -1;
    }
}
