using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class SubLongestPalindrome
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0) return "";
            char[] baseStr = s.ToCharArray();
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    Console.WriteLine(s.Substring(i, j));
                    if (checkPalindromeByString(s.Substring(i, j)) && s.Substring(i, j).Length > result.Length) result = s.Substring(i, j);
                }
            }
            return result;
        }

        public bool checkPalindromeByString(string str)
        {
            char[] charArr = str.ToCharArray();
            if (charArr.Length % 2 == 0)
            {
                for (int i = 0; i < charArr.Length/2; i++)
                {
                    if (charArr[i] != charArr[charArr.Length - 1 - i]) return false;
                }
            }
            else
            {
                for (int i = 0; i < (charArr.Length - 1) / 2; i++)
                {
                    if (charArr[i] != charArr[charArr.Length - 1 - i]) return false;
                }
            }
            return true;
        }
    }
}
