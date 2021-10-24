using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> dicAnagram = new Dictionary<char, int>();
            char[] arrs = s.ToCharArray();
            char[] arrt = t.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (dicAnagram.ContainsKey(arrs[i])) dicAnagram[arrs[i]]++;
                else if (!dicAnagram.ContainsKey(arrs[i])) dicAnagram.Add(arrs[i], 1);

                if (dicAnagram.ContainsKey(arrt[i])) dicAnagram[arrt[i]]--;
                else if (!dicAnagram.ContainsKey(arrt[i])) dicAnagram.Add(arrt[i], -1);
            }

            return dicAnagram.Where(x => x.Value > 0 || x.Value < 0).Any() ? false : true;
        }
    }
}
