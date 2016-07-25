using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.strings
{
    public class FirstNonRepeatingCharacter
    {
        static int NO_OF_CHARS = 256;
        /* Returns an array of size 256 containg count
   of characters in the passed char array */
        int[] getCharCountArray(string str)
        {

            int[] count = new int[256];
            int i;
            for (i = 0; i < str.Length; i++)
                count[str[i]]++;
            return count;
        }

        /* The function returns index of first non-repeating
           character in a string. If all characters are repeating 
           then returns -1 */
        int firstNonRepeating(string str)
        {
            int[] count = getCharCountArray(str);
            int index = -1, i;

            for (i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    index = i;
                    break;
                }
            }


            return index;
        }

        /* Driver program to test above function */
        public int Main()
        {
            string str = "geeksforgeeks";
            int index = firstNonRepeating(str);
            if (index == -1)
                Console.WriteLine("Either all characters are repeating or string is empty");
            else
                Console.WriteLine("First non-repeating character is %c", str[index]);
            return 0;
        }
    }
}
