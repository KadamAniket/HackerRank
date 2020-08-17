using System;
using System.Collections.Generic;
using System.Text;

// https://www.hackerrank.com/challenges/time-conversion/problem

namespace HackerRank
{
    public static class MilitaryTimeConversion
    {

        static string timeConversion(string s)
        {
            string militaryFormatDate = string.Empty;

            Int64 hourValue = Convert.ToInt64(s.Split(':')[0]);

            if (s.Contains("AM"))
            {
                militaryFormatDate = hourValue == 12 ? s.Replace(s.Split(':')[0], "00") : s;
                militaryFormatDate = militaryFormatDate.Replace("AM", "");
            }
            else {
                militaryFormatDate = hourValue ==12 ? s : s.Replace(s.Split(":")[0], (hourValue + 12).ToString()) ;
                militaryFormatDate = militaryFormatDate.Replace("PM", "");
            }

            return militaryFormatDate;

        }

        public static void calculate()
        {
            string s = "07:05:45AM";
            //string s = "12:00:00PM";

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
