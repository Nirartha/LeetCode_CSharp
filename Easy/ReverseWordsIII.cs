using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class ReverseWordsIII
    {
        public string ReverseWords(string s)
        {
            string result = "";
            string[] arrStr = s.Split(" ");
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (i == arrStr.Length - 1) result += reverseSingleWord(arrStr[i]);
                else result += reverseSingleWord(arrStr[i]) + " ";
            }
            return result;
        }

        private string reverseSingleWord(string word)
        {
            if (word.Length <= 1) return word;

            char[] arr = word.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char tempChar = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tempChar;
            }

            return new string(arr);
        }
    }
}
