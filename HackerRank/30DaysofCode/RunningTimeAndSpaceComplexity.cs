using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    class RunningTimeAndSpaceComplexity
    {
        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static void calculate()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int testCases = Convert.ToInt32(Console.ReadLine());
            int num;
            for (int i = 1; i <= testCases; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (isPrime(num))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }

        }

    }
}
