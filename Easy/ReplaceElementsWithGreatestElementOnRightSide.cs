using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 1) arr[0] = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1) arr[arr.Length - 1] = -1;
                else
                {
                    int tempGreatestNbr = 0;
                    for (int j = i + 1; j < arr.Length; j++) if (arr[j] > tempGreatestNbr) tempGreatestNbr = arr[j];
                    arr[i] = tempGreatestNbr;
                }
            }

            return arr;


            /* for loop from end to begin
            int max = -1;
            var result = new int[n];
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                result[i] = max;
                max = Math.Max(max, arr[i]);
            }
        
            return result;
            */

        }
    }
}
