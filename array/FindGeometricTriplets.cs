using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class FindGeometricTriplets
    {
        // The function prints three elements in GP if exists
        // Assumption: arr[0..n-1] is sorted.
        void findGeometricTriplets(int[] arr, int n)
        {
            if (n < 3)
                return;
            int i, j, k;
            int x, y;
            for (j = 1; j < n - 1; j++)
            {
                i = 0; k = n - 1;
                while (i < j && k > j)
                {
                    x = (arr[j] * arr[j]);
                    y = (arr[i] * arr[k]);
                    if (x == y)
                    {
                        Console.WriteLine("{0} {1} {2}", arr[i], arr[j], arr[k]);
                        i++; k--;
                    }
                    else if (x > y)
                        i++;
                    else
                        k--;
                }

            }
        }

        // Driver code
        public int Main()
        {
            // int arr[] = {1, 2, 6, 10, 18, 54};
            // int arr[] = {2, 8, 10, 15, 16, 30, 32, 64};
            // int arr[] = {1, 2, 6, 18, 36, 54};
            int[] arr = { 1, 2, 4, 16 };
            // int arr[] = {1, 2, 3, 6, 18, 22};
            int n = arr.Length;

            findGeometricTriplets(arr, n);

            return 0;
        }
    }
    /*
    ---Find all triplets in a sorted array that forms Geometric Progression
Given a sorted array of distinct positive integers, print all triplets that forms Geometric Progression with integral common ratio.

A geometric progression is a sequence of numbers where each term after the first is found by multiplying 
the previous one by a fixed, non-zero number called the common ratio. 
For example, the sequence 2, 6, 18, 54,… is a geometric progression with common ratio 3.
    */
}
