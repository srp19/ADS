using System;
/*
Given an array of size n, find a peak element in the array. 
Peak element is the element which is greater than or equal to its neighbors. 
For example - In Array {1,4,3,6,7,5}, 4 and 7 are peak elements. 
We need to return any one peak element.
*/
namespace ADS.array
{
    public class PeakElement
    {
        public static int? getPeakElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            int n = array.Length;

            int start = 0;
            int end = n - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if ((mid == 0 || array[mid - 1] <= array[mid]) && 
                    (mid == n - 1 || array[mid] >= array[mid + 1]))
                {
                    return array[mid]; // array[mid] is peak element
                }
                else if (mid > 0 && array[mid - 1] > array[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return null;
        }

        public static void Main()
        {
            int[] array = new int[] { 40, 10, 20, 45, 50, 65, 90, 35, 25 };
            int? peak = getPeakElement(array);
            Console.WriteLine(peak != null ? "Peak Element is " 
                + peak.Value : "No peak element!");
        }
    }
    public class PeakElementRecursive
    {
        private int? FindPeak(int[] array, int start, int end)
        {
            if (array == null)
            {
                return null;
            }
            if(array.Length == 0)
            {
                return null;
            }
            int n = array.Length;
            int mid = (start + end) / 2;
            if ((mid == 0 || array[mid - 1] <= array[mid]) && (mid == n-1 || array[mid] >= array[mid + 1]))
            {
                return array[mid];
            }
            else
            {
                if (mid > 0 && array[mid - 1] > array[mid])
                {
                    return FindPeak(array, start, mid - 1);
                }
                else
                {
                    return FindPeak(array, mid + 1, end);
                }
            }
        }


        public void Main()
        {
            int[] array = new int[] { 40, 10, 20, 45, 50, 65, 90, 35, 25 };
            Console.WriteLine(FindPeak(array, 0, array.Length - 1));
        }
    }
}
