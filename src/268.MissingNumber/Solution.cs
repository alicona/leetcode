/*
Given an array nums containing n distinct
numbers in the range [0, n], return the only 
number in the range that is missing from the array.
*/

namespace _268.MissingNumber
{
    public class Solution
    {
public int MissingNumber(int[] nums) {
        return  nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    }

        public int MissingNumber3(int[] nums) {

            var arrayLength = nums.Count();
            var extra = -1;
            var swap = -1;

            for (int i = 0; i < arrayLength; i++)
            {
                if(nums[i] != arrayLength) // 8
                {
                    swap = nums[i];
                    nums[i] = nums[swap];
                    nums[swap] = swap;
                }
                else
                {
                    swap = nums[i];
                    nums[i] = extra;
                    extra = swap;
                }
                
            }

            if(extra == -1) return arrayLength;

            for (int i = 0; i < arrayLength; i++)
            {
                if(nums[i] == -1)
                {
                    return i;
                }
            }
            return extra;
        } // 0,1,2,3,4,5,6,-1,7     extra 9   swap = 1    length = 9

        public int MissingNumber2(int[] nums) {

            var arrayLength = nums.Count();
            var arrayHelper = new int[arrayLength+1];

            foreach (var num in nums)
            {
                arrayHelper[num] = num+1;
            }

            for (int i = 0; i < arrayHelper.Count(); i++)
            {
                if(arrayHelper[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

