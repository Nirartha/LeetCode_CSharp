using System;
namespace LeetCode
{
    public class LongerOneThanZero
    {
        public LongerOneThanZero() { }
        
        public bool CheckZeroOnes(string s)
        {
            if (s.Length == 0) return false;
            if (s.Length == 1 && s == "1") return true;

            int Zeros = 0, tempZeros = 0;
            int Ones = 0, tempOnes = 0;
            foreach (char i in s.ToCharArray())
            {
                if (i == '0')
                {
                    tempZeros++;
                    tempOnes = 0;
                }
                else
                {
                    tempOnes++;
                    tempZeros = 0;
                }
                if (tempZeros > Zeros) Zeros = tempZeros;
                if (tempOnes > Ones) Ones = tempOnes;
            }
            
            return Ones > Zeros ? true : false;
        }

    }
}
