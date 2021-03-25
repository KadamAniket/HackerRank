using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class DayOfProgrammer
    {
        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            if(year==1918)
            return "26.09." + year;

            if ((year >= 1700 && year <= 1917 && year % 4 == 0) ||
                (year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))))
            {
                return "12.09." + year;
            }
            else
            {
                return "13.09." + year;
            }

        }

        public static void calculate()
        {
            Console.WriteLine(dayOfProgrammer(1984));
            Console.WriteLine(dayOfProgrammer(2017));
            Console.WriteLine(dayOfProgrammer(2016));
            Console.WriteLine(dayOfProgrammer(1800));
            Console.WriteLine(dayOfProgrammer(1918));
        }
    }
}
