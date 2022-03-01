using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 1952. Three Divisors
     * 
     * Runtime: 50 ms, faster than 53.33% of C# online submissions for Three Divisors.
     * Memory Usage: 27 MB, less than 53.33% of C# online submissions for Three Divisors.
     * 
     * Constraints:
     * 1 <= n <= 104
     */
    class ThreeDivisors
    {
        public bool IsThree(int n)
        {
            int countDivisors = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) countDivisors++;
            }
            return countDivisors == 3;
        }
    }
}
