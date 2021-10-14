using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class NbrofDaysBetween2Dates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            //TimeSpan ts = DateTime.Parse(date1).Subtract(DateTime.Parse(date2)).Duration();
            return Int32.Parse(DateTime.Parse(date1).Subtract(DateTime.Parse(date2)).Duration().Days.ToString());
        }



        /* Beats 99% on time and space - cybercan11
        public int DaysBetweenDates(string date1, string date2) {
            int diffDays = 0;
            int d1Year = Convert.ToInt32(date1.Substring(0,4));
            int d2Year = Convert.ToInt32(date2.Substring(0,4));
            int d1Month = Convert.ToInt32(date1.Substring(5,2));
            int d2Month = Convert.ToInt32(date2.Substring(5,2));
            int d1Day = Convert.ToInt32(date1.Substring(8,2));
            int d2Day = Convert.ToInt32(date2.Substring(8,2));
            return (int)Math.Abs(calcDate(d1Year,d1Month,d1Day)-calcDate(d2Year,d2Month,d2Day));
        }
        public int calcDate(int year, int month, int days){
            var monthArr = new int[12]{31,28,31,30,31,30,31,31,30,31,30,31};
            int totalDays = (year - 1900 - 1)*365;
            totalDays+=((year-1900-1)/4);
            for(int i=0;i<month-1;i++){
                totalDays+=monthArr[i];
            }
            totalDays+=days;
            if(month>2){
                if(year%4==0){
                    if(year%100==0){
                        if(year%400==0)
                            totalDays++;
                    }
                    else
                        totalDays++;
                }
            }
            return totalDays;
        }
        */
    }
}
