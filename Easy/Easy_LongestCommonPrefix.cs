using System;
using System.Text;

namespace LeetCode
{
    public class Easy_LongestCommonPrefix
    {
        public Easy_LongestCommonPrefix() { }

        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0)
                return "";

            StringBuilder prefix = new StringBuilder(strs[0]);

            foreach (string word in strs)
            {

                if (prefix.Length > word.Length)
                    prefix.Length = word.Length;

                for (int i = 0; i < prefix.Length; i++)
                {
                    if (word[i] != prefix[i])
                    {
                        prefix.Length = i;
                        break;
                    }
                }

            }
            return prefix.ToString();
        }
    }
}
