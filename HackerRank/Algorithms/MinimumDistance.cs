using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class MinimumDistance
    {
        // Complete the minimumDistances function below.
        static int minimumDistances(int[] a)
        {
            int minDist = int.MaxValue;

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j] && Math.Abs(i - j) < minDist)
                    {
                        minDist = Math.Abs(i - j);
                    }
                }
            }

            return minDist == int.MaxValue ? -1 : minDist;

        }

        public static void calculate()
        {
            var input = new int[] {7,1,3,4,1,7 };
            Console.WriteLine(minimumDistances(input));
            input = new int[] { 3,2,1,2,3 };
            Console.WriteLine(minimumDistances(input));
        }

    }
}
