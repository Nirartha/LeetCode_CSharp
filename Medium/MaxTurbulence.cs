using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class MaxTurbulence
    {
        public int MaxTurbulenceSize(int[] arr)
        {
            if (arr.Length <= 1) return 1;
            if (arr.Length == 2) return arr[0] == arr[1] ? 1 : 2;

            int result = 0;
            bool pattern = arr[0] > arr[1];
            int temp = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (pattern)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        temp++;
                        pattern = false;
                    }
                    else
                    {
                        temp = arr[0] == arr[1] ? 1 : 2;
                        pattern = true;
                    }
                }
                else
                {
                    if (arr[i - 1] < arr[i])
                    {
                        temp++;
                        pattern = true;
                    }
                    else
                    {
                        temp = arr[0] == arr[1] ? 1 : 2;
                        pattern = false;
                    }
                }
                result = Math.Max(temp, result);
            }
            return result;
        }
    }
}
