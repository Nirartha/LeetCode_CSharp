using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> prev = new List<int> { 1 };

            for (int i = 1; i <= rowIndex; i++)
            {
                IList<int> cur = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                    cur.Add(prev[j - 1] + prev[j]);

                cur.Add(1);
                prev = cur;
            }
            
            return prev;
        }
    }
}
