using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DiagonalDifference
    {

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum1 += arr[i][i];
                sum2 += arr[i][arr.Count - 1 - i];
            }

            return Math.Abs(sum1 - sum2);

        }

        public static void calculate()
        {

            var list = new List<List<int>>();
            list.Add(new List<int> { 11, 2, 4 });
            list.Add(new List<int> { 4, 5, 6 });
            list.Add(new List<int> { 10, 8, -12 });

            Console.WriteLine(diagonalDifference(list));

        }

    }
}
