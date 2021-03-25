using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Algorithms
{
    public class StickCut
    {
        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            var stickCutCount = new List<int>();
            int stickReduceCount;
            while (!arr.All(m => m == 0))
            {
                int shortestStick = getMinimumValue(arr);
                stickReduceCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        arr[i] -= shortestStick;
                        stickReduceCount++;
                    }
                }

                stickCutCount.Add(stickReduceCount);
            }

            return stickCutCount.ToArray();

        }

        public static int getMinimumValue(int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min && arr[i] != 0)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static void calculate()
        {
            var input = new int[] {1,2,3 };
            Console.WriteLine(string.Join(" ", cutTheSticks(input)));
            input = new int[] { 5, 4, 4, 2, 2, 8 };
            Console.WriteLine(string.Join(" ", cutTheSticks(input)));
        }
    }
}
