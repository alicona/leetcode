namespace _11.ContainerWithMostWater;
/// <summary>
/// You are given an integer array height of length n. 
/// There are n vertical lines drawn such that the two e
/// ndpoints of the ith line are (i, 0) and (i, height[i]).
///
/// Find two lines that together with the x-axis form a container, 
/// such that the container contains the most water.
///
/// Return the maximum amount of water a container can store.
/// Notice that you may not slant the container.
/// </summary>
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while(left < right)
        {
            var area = CalculateArea(right-left, Math.Min(height[left], height[right]));
            maxArea = Math.Max(area, maxArea);

            if(height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    private int CalculateArea(int b, int h)
    {
        return b * h;
    }
}
