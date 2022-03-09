using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 388. Longest Absolute File Path
     * 
     * Runtime: 52 ms, faster than 99.10% of C# online submissions for Longest Absolute File Path.
     * Memory Usage: 36.6 MB, less than 9.01% of C# online submissions for Longest Absolute File Path.
     * 
     * Constraints:
     * 1 <= input.length <= 10^4
     * input may contain lowercase or uppercase English letters, a new line character '\n', a tab character '\t', a dot '.', a space ' ', and digits.
     * 
     */
    class LongestAbsoluteFilePath
    {
        public int LengthLongestPath(string input)
        {
            var paths = input.Split('\n');
            var maxPathLength = 0;
            var levelPathLength = new Dictionary<int, int>();
            levelPathLength.Add(0, 0);
            foreach (var path in paths)
            {
                var actualPath = path.Replace("\t", "");
                var curLevel = path.Length - actualPath.Length + 1;
                var length = levelPathLength[curLevel - 1] + actualPath.Length;

                if (actualPath.Contains("."))
                {
                    maxPathLength = Math.Max(maxPathLength, length);
                }
                else
                {
                    length++; //add "/"
                    if (levelPathLength.ContainsKey(curLevel)) levelPathLength[curLevel] = length;
                    else levelPathLength.Add(curLevel, length);
                }
            }
            return maxPathLength;
        }
    }
}
