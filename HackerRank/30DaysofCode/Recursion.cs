using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._30DaysOfCode
{
    public class Recursion
    {
        public static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n-1);
            }

            return 1;
        }

        public static void calculate()
        {
            Console.WriteLine(factorial(3));
        }
    }
}
