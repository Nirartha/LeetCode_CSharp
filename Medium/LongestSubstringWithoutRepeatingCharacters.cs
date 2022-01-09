using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result = Math.Max(result, countLength(s.Substring(i)));
            }
            return result;
        }

        int countLength(string s)
        {
            char[] charS = s.ToCharArray();
            Boolean[] booleanArrS = new Boolean[128];
            int counts = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int val = charS[i];
                if (booleanArrS[val]) return counts;
                booleanArrS[val] = true;
                counts++;
            }
            return counts;
        }
    }
}
