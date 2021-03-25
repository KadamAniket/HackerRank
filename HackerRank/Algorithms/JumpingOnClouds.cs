using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int jumpCount = 0;
            int i = 0;
            do
            {
                i += (i + 2 < c.Length && c[i + 2] != 1) ? 2 : 1;
                jumpCount++;

            } while (i != c.Length - 1);


            return jumpCount;

        }

        public static void calculate()
        {
            var input = new int[] { 0, 1, 0, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(input));

            input = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(input));

            input = new int[] { 0, 0, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(input));

            input = new int[] { 0, 0, 0, 1, 0, 0 };
            Console.WriteLine(jumpingOnClouds(input));
        }
    }
}
