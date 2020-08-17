using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    // https://www.hackerrank.com/challenges/arrays-ds/problem
    public class ReverseArray
    {

        // Complete the reverseArray function below.
        static int[] reverseArray(int[] a)
        {
            int[] reverse = new int[a.Length];
            for(int i = a.Length - 1; i >= 0; i--)
            {
                reverse[i] = a[a.Length - 1 - i];
            }

            return reverse;

        }

        public static void calculate()
        {
            Console.WriteLine(string.Join(" ",reverseArray(new int[]{ 1,2,3,4,5})));
        }


    }
}
