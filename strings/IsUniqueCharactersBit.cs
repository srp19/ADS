using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.strings
{
    public class IsUniqueCharactersBit
    {

        /* --- String contains Unique Characters?
         * Bitwise Operations for calculating Unique Characters
         *  */
        public static bool isUniqueChars(string str)
        {
            if (str.Length > 26)
            { // Only 26 characters
                return false;
            }
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }

        public static void Main(string[] args)
        {
            string[] words = new string[] { "abcde", "hello", "apple", "kite", "padle" };
            foreach (string word in words)
            {
                Console.WriteLine(word + ": " + isUniqueChars(word));
            }
        }

    }
}
