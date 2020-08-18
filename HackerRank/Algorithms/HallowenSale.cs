using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    // https://www.hackerrank.com/challenges/halloween-sale/problem 
    public class HallowenSale
    {

        //static int howManyGames(int p, int d, int m, int s)
        //{

        //    int gameCount = 0;

        //    while (s >= p) {
        //        s -= Math.Max(p,m);
        //        gameCount++;
        //        if (p <= m)
        //        {
        //            p = m;
        //        }
        //        else
        //        {
        //            p -= d;
        //        }
        //    }

        //    return gameCount;

        //}


        // Complete the howManyGames function below.
        static int howManyGames(int p, int d, int m, int s)
        {
            int count = 0;

            while (s >= p)
            {
                count++;
                s -= p;
                p = Math.Max(p - d, m);
            }

            return count;

        }

        public static void calculate()
        {
            //Console.WriteLine(howManyGames(20,3,6,80));
            //Console.WriteLine(howManyGames(20, 3, 6, 85));
           // Console.WriteLine(howManyGames(1, 1, 1, 1));
            Console.WriteLine(howManyGames(16, 2, 1, 9981));
        }

    }
}
