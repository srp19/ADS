using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class CountInversionOfSize3
    {

        /**
         * Time complexity of this method is O(n^2)
         * Space complexity is O(1)
         */
        /*
                *Each greater element on left side of middle element can be in
                *  inversion triplet with every element on right side of middle element.
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
