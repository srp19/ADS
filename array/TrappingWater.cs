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
        public void Test()
        {
            int[] input = new int[] { 1,5,2,3,1,7,2,4 };
            Console.WriteLine(TrapWater(input));
        }
    }
    
}
