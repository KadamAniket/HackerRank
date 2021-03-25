using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class BeautifulDaysAtMovie
    {
        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            int beautifulDayCount = 0;
            int reversedNumber;

            for(int start=i;start <= j; start++)
            {
                reversedNumber = reverseNumber(start);
                if ((Math.Abs(start - reversedNumber) % k) == 0)
                {
                    beautifulDayCount++;
                }
            }

            return beautifulDayCount;

        }

        private static int reverseNumber(int number)
        {
            int remainder = 0;
            int reverseNumber = 0;

            while (number != 0)
            {
                remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number = number / 10;
            }

            return reverseNumber;
        }

        public static void calculate()
        {
            Console.WriteLine(beautifulDays(20,23,6));

            Console.WriteLine(beautifulDays(13, 45, 3));
        }
    }
}
