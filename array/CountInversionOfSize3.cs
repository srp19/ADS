using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class CountInversionOfSize3
    {

        /*
         ---Count Inversions of size three in a give array
            Given an array arr[] of size n. Three elements arr[i], arr[j] and arr[k] 
            form an inversion of size 3 if a[i] > a[j] >a[k] and i < j < k. 
            Find total number of inversions of size 3.

            Example:

            Input:  {8, 4, 2, 1}
            Output: 4
            The four inversions are (8,4,2), (8,4,1), (4,2,1) and (8,2,1).

            Input:  {9, 6, 4, 5, 8}
            Output:  2
            The two inversions are {9, 6, 4} and {9, 6, 5}


            Simple approach :- Loop for all possible value of i, j and k and
            check for the condition a[i] > a[j] > a[k] and i < j < k.


            We can reduce the complexity if we consider every element arr[i] as middle element of inversion, 
            find all the numbers greater than a[i] whose index is less than i, find all the numbers which are 
            smaller than a[i] and index is more than i. We multiply the number of elements greater than a[i] to 
            the number of elements smaller than a[i] and add it to the result.
            Each greater element on left side of middle element can be in
            inversion triplet with every element on right side of middle element.
                e.g. {6,5,4,3,2,1}
                If we consider 4 as middle element then two greater elements on left side
                are {6,5} and three smaller elements on right side are {3,2,1}.
                Total 2*3=6 inversion triplets considering 4 as middle element will be:
                {6,4,3}
                {6,4,2}
                {6,4,1}
                {5,4,3}
                {5,4,2}
                {5,4,1} 
               */
        public int findInversions(int[] input)
        {
            int inversion = 0;
            for (int i = 1; i < input.Length - 1; i++)
            {
                int larger = 0;
                for (int k = 0; k < i; k++)
                {
                    if (input[k] > input[i])
                    {
                        larger++;
                    }
                }
                int smaller = 0;
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (input[k] < input[i])
                    {
                        smaller++;
                    }
                }
                inversion += smaller * larger;
            }
            return inversion;
        }

        public static void Main(String[] args)
        {
            int[] input = { 9, 6, 4, 5, 8 };
            CountInversionOfSize3 ci = new CountInversionOfSize3();
            Console.WriteLine(ci.findInversions(input));
        }
    }

}
