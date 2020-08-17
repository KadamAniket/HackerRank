using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    // https://www.hackerrank.com/challenges/circular-array-rotation/problem
    public class CirularArrayRotation
    {
        // Complete the circularArrayRotation function below.
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            var rotatedArray = new int[a.Length];
            var resultedArray = new int[queries.Length];
            for(int i = 0; i < a.Length; i++)
            {
                rotatedArray[(i + k) % a.Length] = a[i];
            }

            for(int i = 0; i < queries.Length; i++)
            {
                resultedArray[i] = rotatedArray[queries[i]];
            }

            return resultedArray;
        }

        public static void calcualte()
        {
            Console.WriteLine(string.Join(" ",circularArrayRotation(new int[] { 3,4,5},2,new int[] { 1,2})));
        }
    }
}
