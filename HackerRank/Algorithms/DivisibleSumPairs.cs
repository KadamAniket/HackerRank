using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
    public static class DivisibleSumPairs
    {


        public static void calculate() {
            int k = 5;
            var ar = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(divisibleSumPairs(ar.Length, k, ar));

            k = 3;
            ar = new int[] { 1, 3, 2, 6, 1, 2 };

            Console.WriteLine(divisibleSumPairs(ar.Length, k, ar));
        }

        // Complete the divisibleSumPairs function below.
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++) {

                for (int j = i+1; j < n; j++) {
                    if((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }


            }

            return count;

        }
    }
}
