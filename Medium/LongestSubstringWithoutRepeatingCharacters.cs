using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        /** Solution I 
            Runtime 4ms, Beats 94.39%
            Memory 44.46MB, Beats 33.70%
        */
        public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dicCount = new Dictionary<char, int>();
        int start = 0;
        int maxLength = 0;

            for (int i = 0; i < s.Length; i++) {
                char ch = s[i];
                if (dicCount.ContainsKey(ch) && dicCount[ch] >= start) start = dicCount[ch] + 1;
                
                dicCount[ch] = i;
                maxLength = Math.Max(maxLength, i - start + 1);
            }
    
            return maxLength;
        }

        /** Solution II 
            Runtime 738ms, Beats5.03%
            Memory 35.53MB, Beats 100.00%
        */
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
