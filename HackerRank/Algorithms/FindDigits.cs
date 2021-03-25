using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class FindDigits
    {

        // String conversion
        //static int findDigits(int n)
        //{
        //    int divisorCount = 0;

        //    foreach(char number in n.ToString())
        //    {
        //        int num = Convert.ToInt32(number.ToString());
        //        if (num > 0 && n % num  == 0)
        //        {
        //            divisorCount++;
        //        }
        //    }

        //    return divisorCount;

        //}

        static int findDigits(int n)
        {
            int divisorCount = 0;
            int number = n;
            while (n != 0)
            {
                if ((n % 10 > 0) && (number % (n % 10)) == 0){
                    divisorCount++;
                }
                n = n / 10;
            }

            return divisorCount;

        }

        public static void calculate()
        {
            Console.WriteLine(findDigits(12));
            Console.WriteLine(findDigits(1012));
        }
    }
}
