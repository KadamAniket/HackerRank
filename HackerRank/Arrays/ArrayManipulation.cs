using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank.Arrays
{
    public class ArrayManipulation
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            long maxValue = 0;
            long[] arr = new long[n];

            foreach (var query in queries)
            {
                for (int i = query[0] - 1; i <= query[1] - 1; i++)
                {
                    arr[i] += query[2];
                }
            }

            maxValue = arr.Max();

            return maxValue;

        }

        static long arrayManipulationPrefixSum(int n, int[][] queries)
        {
            long[] numList = new long[n + 2];

            foreach (var query in queries)
            {
                numList[query[0]] += query[2];
                numList[query[1] + 1] -= query[2];
            }

            long max = 0;
            for(int i = 1; i < numList.Length; i++)
            {
                numList[i] += numList[i - 1];
                if(numList[i] > max) { max = numList[i]; }
            }
            return max;
            
        }

        public static void calculate()
        {
            int[][] queries = new int[][]
            {
                new int[]{1,2,100},
                new int[]{2,5,100},
                new int[]{3,4,100}
            };

            int n = 5;

            Console.WriteLine(arrayManipulation(n, queries));
            Console.WriteLine(arrayManipulationPrefixSum(n, queries));

            queries = new int[][]
            {
                new int[]{2, 6 ,8},
                new int[]{3, 5 ,7},
                new int[]{ 1, 8, 1 },
                new int[]{5 ,9, 15},
            };

            n = 10;
            Console.WriteLine("");
            Console.WriteLine(arrayManipulation(n, queries));
            Console.WriteLine(arrayManipulationPrefixSum(n, queries));
        }
    }
}
