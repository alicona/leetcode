namespace _4.MedianTwoSortedArrays;

/// <summary>
/// Given two sorted arrays nums1 and nums2 of size m and n respectively,
/// return the median of the two sorted arrays.
///
/// The overall run time complexity should be O(log (m+n)).
/// </summary>
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var mergedArray = MergeArray(nums1, nums2, nums1.Length, nums2.Length);
        
        var len = mergedArray.Length;

        if(len == 1) return mergedArray[0];

        var med = len / 2;

        if(len % 2 > 0)
        {
            return mergedArray[med];
        }
        
        
        return (mergedArray[med] + mergedArray[med - 1]) / 2.0;
    }

    private int[] MergeArray(int[] nums1, int[] nums2, int len1, int len2)
    {
        var nums3 = new int[len1 + len2];
        int index1 = 0, index2 = 0, index3 = 0;

        while (index1 < len1 && index2 < len2)
        {
            if(nums1[index1] < nums2[index2])
            {
                nums3[index3] = nums1[index1];
                index1++;
            }
            else
            {
                nums3[index3] = nums2[index2];
                index2++;
            }

            index3++;
        }

        while (index1 < len1)
        {
            nums3[index3] = nums1[index1];
            index1++;
            index3++;
        }

        while (index2 < len2)
        {
            nums3[index3] = nums2[index2];
            index2++;
            index3++;
        }

        return nums3;
    }
}
