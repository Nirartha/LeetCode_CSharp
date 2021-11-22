using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    class RearrangeWordsinaSentence
    {
        public string ArrangeWords(string text)
        {
            string[] strArr = text.Split(" ");
            int maxLength = strArr.Max(x => x.Length);
            string res = "";
            for (int i = 1; i <= maxLength; i++)
            {
                for (int j = 0; j < strArr.Length; j++)
                {
                    if (strArr[j].Length == i) res += strArr[j].ToLower() + " ";
                }
            }
            return res.Substring(0, 1).ToUpper() + res.Substring(1, res.Length - 2);
        }
    }
}
