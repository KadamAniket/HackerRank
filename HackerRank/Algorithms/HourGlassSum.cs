using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

    public class HourGlassSum
    {
        int[,] arr;

        public HourGlassSum()
        {
            //arr = new int[6, 6]{
            //    {1, 1 ,1 ,0, 0, 0},
            //    {0, 1, 0, 0, 0, 0},
            //    {1 ,1, 1 ,0 ,0, 0},
            //    {0 ,0 ,2 ,4 ,4, 0},
            //    {0, 0, 0, 2 ,0, 0},
            //    {0, 0, 1 ,2, 4, 0}
            //};

            arr = new int[6, 6] {
        { -1, -1, 0, -9, -2, -2 },
        { -2, -1, -6, -8, -2, -5},
        { -1 ,-1, -1, -2, -3, -4},
        { -1, -9, -2, -4, -4, -5},
        { -7, -3, -3, -2, -9, -9},
        { -1, -3, -1, -2, -4, -5}
            };
        }

        public void showHourGlass()
        {
            int largestHourGlass = -99999, sum=0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                    if (i + 2 < 6 && j + 2 < 6)
                    {
                    sum = calculate(arr, i, j);
                    Console.Write(" {0}  ", sum);
                    largestHourGlass = sum > largestHourGlass ? sum : largestHourGlass;
                    }
                }
            }

            Console.WriteLine("\n\n\n Largest {0}", largestHourGlass);

        }

        private int calculate(int[,] arr, int iStartIndex, int jStartIndex)
        {
            int sum = 0;

           
                for (int count = 0; count < 3; count++)
                {
                    sum += arr[iStartIndex, jStartIndex + count] + arr[iStartIndex + 2, jStartIndex + count];
                }
                sum += arr[iStartIndex + 1, jStartIndex + 1];
           

            return sum;
        }
    }
}

