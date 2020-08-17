using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public static class BreakingBestAndWorstRecord
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int min = 0, max = 0, minCount = 0, maxCount = 0;
            min = max = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min) { min = scores[i]; minCount++; }
                if (scores[i] > max) { max = scores[i]; maxCount++; }
            }

            return new int[] { maxCount,minCount };

        }

        public static void Calculate()
        {
            var sampleInput1 = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            var sampleInput2 = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            var result1 = breakingRecords(sampleInput1);
            var result2 = breakingRecords(sampleInput2);

            Console.WriteLine(string.Join(" ", result1));
            Console.WriteLine(string.Join(" ", result2));
        }
    }
}
