using System;
namespace LeetCode
{
    public class BulbSwitcher
    {
        public BulbSwitcher() { }

        public int BulbSwitch(int n)
        {
            /*
            if (n == 0) return 0;

            //round 0
            int[] bulbArr = new int[n];

            //round 1: turn on all bulbs
            for (int x = 0; x < bulbArr.Length; x++) bulbArr[x] = 1;

            if (n > 1)
            {
                int round = 2;
                while (round <= n)
                {
                    for (int i = round - 1; i < bulbArr.Length; i += round)
                    {
                        if (bulbArr[i] == 1) bulbArr[i] = 0;
                        else bulbArr[i] = 1;
                    }
                    round++;
                }
            }

            int sum = 0;
            Array.ForEach(bulbArr, i => sum += i);
            return sum;
            */


            return (int)Math.Sqrt(n);
        }
    }
}
