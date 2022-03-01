using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 1668. Maximum Repeating Substring
     * 
     * 
     * Constraints:
     * 1 <= sequence.length <= 100
     * 1 <= word.length <= 100
     * sequence and word contains only lowercase English letters.
     */
    class MaxRepeatingSubstring
    {
        /**
         * 1668. Maximum Repeating Substring
         * 
         * Runtime: 76 ms, faster than 82.76% of C# online submissions for Maximum Repeating Substring.
         * Memory Usage: 36.1 MB, less than 24.14% of C# online submissions for Maximum Repeating Substring.
         * 
         * Constraints:
         * 1 <= sequence.length <= 100
         * 1 <= word.length <= 100
         * sequence and word contains only lowercase English letters.
         */
        public int MaxRepeating(string sequence, string word)
        {
            if (word.Length > sequence.Length) return 0;
            int result = 0;
            string subS = word;
            while (sequence.IndexOf(subS) != -1)
            {
                result++;
                subS += word;
            }
            return result;
        }
    }
}
