using System;
namespace LeetCode
{
    public class Solution {

      /**
        Runtime 9ms, Beats 46.49%
        Memory 43.24MB, Beats 78.76%
      */
      public bool CheckInclusion(string s1, string s2) {
          if (s1.Length > s2.Length) return false;
  
          int[] freqS1 = new int[26];
          int[] freqS2 = new int[26];
  
          // insert s1
          foreach (char c in s1) {
              freqS1[c - 'a']++;
          }
  
          // initialize s2
          for (int i = 0; i < s1.Length; i++) {
              freqS2[s2[i] - 'a']++;
          }
  
          // compare first freq
          if (freqS1.SequenceEqual(freqS2)) return true;
  
          // update the rest freq and then compare them
          for (int i = s1.Length; i < s2.Length; i++) {
              freqS2[s2[i] - 'a']++;
              freqS2[s2[i - s1.Length] - 'a']--;
  
              if (freqS1.SequenceEqual(freqS2)) return true;
          }
  
          return false;
      }
  }
}
