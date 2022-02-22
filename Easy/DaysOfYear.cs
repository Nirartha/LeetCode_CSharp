using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class DaysOfYear
    {
        /**
         * [Easy] 1154. Day of the Year
         * Constraints:
         * date.length == 10
         * date[4] == date[7] == '-', and all other date[i]'s are digits
         * date represents a calendar date between Jan 1st, 1900 and Dec 31th, 2019.
         */
        public int DayOfYear(string date)
        {
            int result = 0;
            if (date.Length != 10) return result;

            //YYYY-MM-DD
            string[] dateSplit = date.Split('-');

            if (Int32.Parse(dateSplit[0]) < 1900 || Int32.Parse(dateSplit[0]) > 2019) return result;

            int[] daysInMon = new int[] {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            result += Int32.Parse(dateSplit[2]);
            for (int i = 1; i < Int32.Parse(dateSplit[1]); i++) result += daysInMon[i];
            if (Int32.Parse(dateSplit[1]) > 2) result += isLeapYear(Int32.Parse(dateSplit[0])) == true ? 1 : 0;
            return result;
        }


        /**
        * Note:
        * leap year
        * 1. year % 4 == 0 ? Step 2 : Step 5
        * 2. year % 100 == 0 ? Step 3 : Step 4
        * 3. year % 400 == 0 ? Step 4 : Step 5
        * 4. is leap year (366 days)
        * 5. is NOT leap year (365 days)
        */
        private bool isLeapYear(int year)
        {
            if (year % 4 == 0)
                if (year % 100 == 0)
                    if (year % 400 == 0)
                        return true;
                    else return false;
                else return true;
            else return false;
        }
    }
}
