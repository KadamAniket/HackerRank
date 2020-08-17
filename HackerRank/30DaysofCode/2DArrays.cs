using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    public class _2DArrays
    {
        static int calculateLongestHourGlass(int[][] arr)
        {
            int longestHourGlass = int.MinValue;
            int sumHourGlass = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    //Console.WriteLine("{0} {1} {2}", arr[j][i], arr[j][i + 1], arr[j][i + 2]);
                    //Console.WriteLine("  {0}    ", arr[j + 1][i + 1]);
                    //Console.WriteLine("{0} {1} {2}", arr[j + 2][i], arr[j + 2][i + 1], arr[j + 2][i + 2]);
                    // Console.WriteLine();

                    sumHourGlass = arr[j][i] + arr[j][i + 1] + arr[j][i + 2] + arr[j + 1][i + 1] + arr[j + 2][i] + arr[j + 2][i + 1] + arr[j + 2][i + 2];
                    if (sumHourGlass > longestHourGlass)
                    {
                        longestHourGlass = sumHourGlass;
                    }
                }
            }

            return longestHourGlass;
        }

        public static void calculate()
        {
            //int[][] arr = new int[][]
            //{

            //    new int[] { 1, 1, 1, 0, 0, 0 },
            //    new int[] { 0, 1, 0, 0, 0, 0 },
            //    new int[] { 1, 1, 1, 0, 0 ,0 },
            //    new int[] { 0, 0, 2, 4, 4 ,0 },
            //    new int[] { 0, 0, 0, 2, 0 ,0 },
            //    new int[] { 0, 0, 1, 2 ,4 ,0 }
            //};

            int[][] arr = new int[][]
            {
                new int[] {-1 ,-1, 0, -9, -2, -2},
                new int[] {-2, -1, -6, -8, -2, -5},
                new int[] {-1, -1, -1, -2, -3, -4},
                new int[] {-1, -9, -2, -4, -4, -5},
                new int[] {-7, -3, -3, -2, -9, -9},
                new int[] {-1 ,-3, -1, -2, -4, -5}
            };

            Console.WriteLine(calculateLongestHourGlass(arr));


        }
    }
}
