using System;

namespace ADS.array
{
    public class TrappingWater
    {
        private int TrapWater(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }
            int len = height.Length;
            int[] left = new int[len];
            int[] right = new int[len];
            left[0] = height[0];
            right[len - 1] = height[len - 1];
            for (int i = 1; i < len; i++)
            {
                left[i] = Math.Max(height[i], left[i - 1]);
                right[len - i - 1] = Math.Max(height[len - i - 1], right[len - i]);
            }
            int maxWaterTrapped = 0;
            for (int i = 1; i < len - 1; i++)
            {
                int min = Math.Min(left[i], right[i]);
                if (height[i] < min)
                {
                    maxWaterTrapped += min - height[i];
                }
            }
            return maxWaterTrapped;
        }
        public void Main()
        {
            int[] input = new int[] { 1,5,2,3,1,7,2,4 };
            Console.WriteLine(TrapWater(input));
        }
    }
    
}
/*
Trapping Rain Water
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
An element of array can store water if there are higher bars on left and right. We can find amount of water to be stored in every element by finding the heights of bars on left and right sides. The idea is to compute amount of water that can be stored in every element of array. For example, consider the array {3, 0, 0, 2, 0, 4}, we can store two units of water at indexes 1 and 2, and one unit of water at index 2.

A Simple Solution is to traverse every array element and find the highest bars on left and right sides. Take the smaller of two heights. The difference between smaller height and height of current element is the amount of water that can be stored in this array element. Time complexity of this solution is O(n2).

An Efficient Solution is to prre-compute highest bar on left and right of every bar in O(n) time. Then use these pre-computed values to find the amount of water in every array element. 
http://www.geeksforgeeks.org/trapping-rain-water/
 */
