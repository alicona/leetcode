using System;
using System.Collections.Generic;
/*
Given an integer array nums, 
return true if any value appears at least twice in the array, 
and return false if every element is distinct.
*/
namespace _217.ContainsDuplicate
{
    public class Solution
    {
        
        public bool ContainsDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!dictionary.TryAdd(num, num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}