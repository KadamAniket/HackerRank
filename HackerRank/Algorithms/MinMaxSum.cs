using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public static class MinMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            Int64  minSum =0,maxSum =0,sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                sum = 0;
                for (int j = 0; j < arr.Length; j++) {
                    if (j != i)
                    {
                        sum = sum + arr[j];
                    }
                }

                minSum = (sum < minSum || i==0) ? sum : minSum;
                maxSum = sum > maxSum ? sum : maxSum;
            }
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

        public static void calculate()
        {
            int[] arr = new int[] { 100000000, 200000000, 300000000, 400000000, 500000000 };
            miniMaxSum(arr);
        }
    }
}
