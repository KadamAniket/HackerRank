using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/migratory-birds/problem

    public static class MigratoryBirds
    {

        public static void calculate()
        {

            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

            Console.WriteLine(migratoryBirds(arr));

        }

        // Complete the migratoryBirds function below.
        public static int migratoryBirds(List<int> arr)
        {
            int[] result = new int[6];
            
            arr.ForEach(item =>
            {
                result[item] = result[item] + 1;
            });

            return Array.IndexOf(result, result.Max());

        }

    }
}
