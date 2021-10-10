using System;
namespace LeetCode
{
    public class FindWinnerInArray
    {
        public FindWinnerInArray() { }

        public int GetWinner(int[] arr, int k)
        {
            int theBiggestElement = FindTheBiggestOne(arr);
            if (k > arr.Length - 1 || arr[0] == theBiggestElement) return theBiggestElement;

            int i = 0;
            int j = 1;
            int winnerCount = 0;
            while (i < arr.Length && j < arr.Length && winnerCount < k)
            {
                if (arr[i] < arr[j])
                {
                    i = j;
                    j++;
                    winnerCount = 1;
                }
                else
                {
                    j++;
                    winnerCount++;
                }
            }
            return arr[i];
        }

        private int FindTheBiggestOne(int[] arr)
        {
            int goal = 0;
            foreach(int i in arr) if (i > goal) goal = i;
            return goal;
        }
    }
}
