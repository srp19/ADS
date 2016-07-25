using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class TripletSumLessThanTotal
    {
        public virtual int findAllTriplets(int[] input, int total)
        {
            Array.Sort(input);
            int result = 0;
            for (int i = 0; i < input.Length - 2; i++)
            {
                int j = i + 1;
                int k = input.Length - 1;
                while (j < k)
                {
                    if (input[i] + input[j] + input[k] >= total)
                    {
                        k--;
                    }
                    else
                    {
                        result += k - j;
                        j++;
                    }
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            /*
                * Given array with unique numbers 
                * and a total,  find all triplets 
                * whose sum is less than total
                * 
                * */
            int[] input = new int[] { 5, 1, 3, 4, 7 };
            TripletSumLessThanTotal tt =
                new TripletSumLessThanTotal();
            Console.Write(tt.findAllTriplets(input, 12));
        }
    }
}
