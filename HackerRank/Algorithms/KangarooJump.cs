using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/kangaroo/problem

    public static class KangarooJump
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v2 < v1)
            {
                while (x2 <= Double.MaxValue)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                        return "YES";

                }
            }

            return "NO";

        }

        public static void Calculate()
        {
            // 2081 8403 9107 8400
            int x1 = 2081;

            int v1 = 8403;

            int x2 = 9107;

            int v2 = 8400;

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

        }
    }
}
