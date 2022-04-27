using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 
     * Runtime: 157 ms, faster than 50.80% of C# online submissions for Valid Mountain Array.
     * Memory Usage: 43.3 MB, less than 39.84% of C# online submissions for Valid Mountain Array.
     * Constraints:
     * 1 <= arr.length <= 10^4
     * 0 <= arr[i] <= 10^4
     */
    class ValidMountainArr
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr == null || arr.Length < 3) return false;

            bool peak = false;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i +1])
                {
                    if (peak) return false;
                    peak = true;
                }
                else
                {
                    if ((arr[i - 1] <= arr[i] || arr[i] <= arr[i + 1]) && peak) return false;
                    if ((arr[i - 1] >= arr[i] || arr[i] >= arr[i + 1]) && !peak) return false;
                }
            }
            return peak;
        }
    }
}
