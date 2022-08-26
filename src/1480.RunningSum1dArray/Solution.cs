namespace _1480.RunningSum1dArray;
/// Given an array nums. 
/// We define a running sum of an array as 
/// runningSum[i] = sum(nums[0]…nums[i]).
///
/// Return the running sum of nums.
///
public class Solution
{
    public int[] RunningSum(int[] nums) 
    {
        var length = nums.Length;
        var arraySum = new int[length];
        
        arraySum[0] = nums[0];

        for (int i = 1; i < length; i++)
        {
            arraySum[i] = arraySum[i-1] + nums[i];
        }

        return arraySum;
    }
}
