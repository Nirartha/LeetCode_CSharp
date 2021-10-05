using System;
namespace LeetCode
{
    public class Implement_strStr
    {
        public Implement_strStr() { }

        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if (haystack.Length == 0) return -1;
            if (haystack == needle) return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
            return -1;
        }
    }
}
