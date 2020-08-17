using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class HurdleRace
    {

        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            int maxHeight=height[0];

            for(int i = 1; i < height.Length; i++)
            {
                if(height[i] > maxHeight)
                {
                    maxHeight = height[i];
                }
            }

            return k> maxHeight ? 0 : maxHeight - k;

        }


        public static void calculate()
        {
            int k = 4;
            int[] height = new int[] { 1,6,3,5,2};
            Console.WriteLine(hurdleRace(k,height));
        }
    }
}
