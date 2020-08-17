using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    // https://www.hackerrank.com/challenges/chocolate-feast/problem
    public class ChocolateFeast
    {
        static int chocolateFeast(int n, int c, int m)
        {
            int chocolateBarCount = n/c;
            int wrapperCount = n / c;
            
            while(wrapperCount >= m)
            {
                int newBuy = wrapperCount / m;
                chocolateBarCount += newBuy;
                wrapperCount = (wrapperCount % m) + newBuy;
            }
            

            return chocolateBarCount;
        }

        public static void calculate()
        {
            Console.WriteLine(chocolateFeast(15, 3, 2));
            Console.WriteLine(chocolateFeast(10, 2, 5));
            Console.WriteLine(chocolateFeast(12, 4, 4));
            Console.WriteLine(chocolateFeast(6, 2, 2));
        }
    }
}

