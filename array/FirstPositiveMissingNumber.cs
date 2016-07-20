using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Given an unsorted integer array, find the first missing positive integer.

For example,
Given [1,2,0] return 3,
and [3,4,-1,1] return 2.

Your algorithm should run in O(n) time and uses constant space.
 
 */
namespace ADS.array
{
    public class FirstPositiveMissing
    {
        public virtual int firstMissingPositive(int[] nums)
        {
            int startOfPositive = segregate(nums);
            for (int i = startOfPositive; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) + startOfPositive - 1;
                if (index < nums.Length)
                {
                    nums[index] = -Math.Abs(nums[index]);
                }
            }
            for (int i = startOfPositive; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return i - startOfPositive + 1;
                }
            }
            return nums.Length - startOfPositive + 1;
        }

        private int segregate(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                if (nums[start] <= 0)
                {
                    start++;
                }
                else if (nums[end] > 0)
                {
                    end--;
                }
                else
                {
                    swap(nums, start, end);
                }
            }
            return start;
        }

        private void swap(int[] nums, int start, int end)
        {
            int t = nums[start];
            nums[start] = nums[end];
            nums[end] = t;
        }
        public void Main()
        {
            int[] array = { 1, 2, 0 };
            Console.WriteLine(firstMissingPositive(array));
            array = new int[] { 3,4,-1,1 };
            Console.WriteLine(firstMissingPositive(array));
        }
    }
}
