using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class StringRotation
    {
        public bool RotateString(string s, string goal)
        {
            if (s.Length == 0 || goal.Length == 0) return false;
            if (s.Length > 100 || goal.Length > 100) return false;
            if (s.Length != goal.Length) return false;

            string newS = s + s;
            for (int i = 0; i < newS.Length - goal.Length + 1; i++)
            {
                if (newS.Substring(i, goal.Length) == goal) return true;
            }

            return false;
        }
    }
}
