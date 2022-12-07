using System;
using System.Drawing;
using todaycode;

namespace todaycode
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        static void Main(string[] args)
        {
            int length = 0;
            string s = "a";
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dictionary = new Dictionary<char, int>();
                while (i < s.Length && !dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i++], 1);
                }
                if (i - start > length)
                {
                    length = i - start;
                }
            }
            Console.WriteLine(length);
        }

    }
 }