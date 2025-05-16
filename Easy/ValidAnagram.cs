using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    class ValidAnagram
    {
        /** Solution I
            Runtime 1ms, Beats 86.39%
            Memory 43.63, Beats 64.91%
        */
        public bool IsAnagram(string s, string t) {
            int[] arrInt = new int[26];
            foreach (char ch in s.ToCharArray()){
                arrInt[ch-'a'] += 1;
            }
            foreach (char ch in t.ToCharArray()){
                arrInt[ch-'a'] --;
            }
            foreach (int i in arrInt){
                if(i != 0) return false;
            }
            return true;
        }
        
        /** Solution II
            Runtime 6ms, Beats 50.68%
            Memory 43.90MB, Beats 45.71%
        */
        public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
    
            Dictionary<char, int> dicAna = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++){
                if(!dicAna.ContainsKey(s[i])) dicAna[s[i]] = 0;
                if(!dicAna.ContainsKey(t[i])) dicAna[t[i]] = 0;
    
                dicAna[s[i]]++;
                dicAna[t[i]]--;
            }
            return dicAna.Values.All(c => c == 0);
        }
        
        /** Solution III
            Runtime 60ms, Beats 7.18%
            Memory 46.61MB, Beats 5.36%
        */
        public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
    
            var sortedS = String.Concat(s.OrderBy(c => c));
            var sortedT = String.Concat(t.OrderBy(c => c));
    
            return sortedS == sortedT;
        }

        /** Solution IV
            Runtime 132ms, Beats 5.08%
            Memory 38.48MB, Beats 100.00%
        */
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
