using System.Linq;
namespace _15._3Sum;
/// <summary>
/// Given an integer array nums, return all the triplets
/// [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, 
/// and nums[i] + nums[j] + nums[k] == 0.
/// 
/// Notice that the solution set must not contain duplicate triplets.
/// </summary>
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var list = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // since we have a sorted array, if the our first number is
            // higher than 0, anything else will be higher than zero.
            if(nums[i] > 0) break;

            // if the previous number is equal to the current number,
            // no need to check, because it will be a repeted array.
            if(i > 0 && nums[i] == nums[i -1]) continue;

            // if the sum of all  three consecutive is zero,
            // add them to the list and go to the next itheration.
            if((nums[i] + nums[i + 1] + nums[i + 2]) == 0 )
            {
                var internalList = new List<int>();

                internalList.Add(nums[i]);
                internalList.Add(nums[i + 1]);
                internalList.Add(nums[i + 2]);
                list.Add(internalList);

                continue;
            }

            var left = i + 1;
            var right = nums.Length - 1;
            var remain = 0 - nums[i];

            while(left < right )
            {
                if((nums[left] + nums[right]) > remain)
                {
                    right--;
                    continue;
                }

                if((nums[left] + nums[right]) < remain)
                {
                    left++;
                    continue;
                }

                if((nums[left] + nums[right]) == remain)
                {
                    var internalList = new List<int>();

                    internalList.Add(nums[i]);
                    internalList.Add(nums[left]);
                    internalList.Add(nums[right]);

                    list.Add(internalList);
                    
                    left++;
                    right--;

                    while(nums[left] == nums[left -1] && left < right)
                    {
                        left++;
                    }

                    while(nums[right] == nums[right + 1] && left < right)
                    {
                        right--;
                    }
                }
            }
        }

        return list;
    }
}
