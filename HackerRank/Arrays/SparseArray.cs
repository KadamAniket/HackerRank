using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public class SparseArray
    {
        // Complete the matchingStrings function below.
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            var result = new int[queries.Length];

            foreach(var str in strings)
            {
                for(int i=0;i< queries.Length;i++)
                {
                    if (queries[i] == str)
                    {
                        result[i]++;
                    }
                }
            }

            return result;
        }

        public static void calculate()
        {
            var str = new string[] { "aba", "baba", "aba", "xzxb" };
            var queries = new string[] { "aba", "ab", "xzxb" };
            Console.WriteLine(string.Join(" ", matchingStrings(str, queries)));
        }
    }
}
