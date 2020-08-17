using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    // https://www.hackerrank.com/challenges/30-sorting/problem
    public class Sorting
    {
        static void evaluateArraySorting(int[] arr)
        {
            int temp;
            int swapCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j< arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapCount++;
                    }
                }
            }


            Console.WriteLine("Array is sorted in {0} swaps.",swapCount);
            Console.WriteLine("First Element: {0}", arr[0]);
            Console.WriteLine("Last Element: {0}", arr[arr.Length-1]);
        }

        public static void calculate()
        {
            int[] arr = new int[] { 3, 2, 1, 4, 6, 7 };
            evaluateArraySorting(arr);

        }
    }
}
