using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class AngleBetweenHandsofClock
    {
        public double AngleClock(int hour, int minutes)
        {
            return Math.Min(Math.Abs((((double)hour / 12 * 360) % 360 + ((double)minutes / 60 * 30)) - ((double)minutes / 60 * 360)), 360 - Math.Abs((((double)hour / 12 * 360) % 360 + ((double)minutes / 60 * 30)) - ((double)minutes / 60 * 360)));
        }
    }
}
