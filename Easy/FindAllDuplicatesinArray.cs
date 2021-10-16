using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class FindAllDuplicatesinArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return new int[] { };

            List<int> result = new List<int>();
            Dictionary<int, int> intKeyValues = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (intKeyValues.ContainsKey(num)) intKeyValues[num]++;
                else intKeyValues.Add(num, 1);

                if (intKeyValues[num] == 2) result.Add(num);
            }

            return result;
        }
    }
}
