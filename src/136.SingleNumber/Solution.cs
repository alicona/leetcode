namespace _136.SingleNumber;
public class Solution
{
    public int SingleNumber(int[] nums) 
    {
        var result = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}