﻿using System;
namespace LeetCode
{
    public class Easy_NumberToZeroOfSteps
    {
        public Easy_NumberToZeroOfSteps() { }

        public int NumberOfSteps(int num)
        {
            if (num == 0) return 0;
            else if (num % 2 == 0) return 1 + NumberOfSteps(num / 2);
            else return 1 + NumberOfSteps(num - 1);
        }
    }
}
