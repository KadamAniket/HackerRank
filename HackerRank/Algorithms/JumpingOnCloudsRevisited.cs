using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class JumpingOnCloudsRevisited
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c, int k)
        {
            int energyLevel = 100;
            int i = 0;
            do
            {
                i = i + k;
                if(i >= c.Length)
                {
                    i = i % c.Length;
                }
                energyLevel--;

                if (c[i] == 1)
                {
                    energyLevel -= 2;
                }

            } while (i != 0);


            return energyLevel;
        }

        public static void calculate() {

            var input = new int[] {0,0,1,0 };

            Console.WriteLine(jumpingOnClouds(input,2));


            input = new int[] { 0, 0, 1, 0, 0, 1, 1, 0 };
            Console.WriteLine(jumpingOnClouds(input, 2));

            input = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            Console.WriteLine(jumpingOnClouds(input, 3));

        }
    }
}
