using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/the-birthday-bar/problem
    public static class BirthdayBar
    {
        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < s.Count; i++)
            {
                sum = 0;
                int j = i;
                while ((i + m) <= s.Count && j < (i + m)) {
                    sum += s[j];
                    j++;
                }
                if (sum == d) { count++; }
            }

            return count;

        }

        public static void calculate()
        {
            var input1 = new int[] { 1, 2, 1, 3, 2 };
            int day1 = 3;
            int month1 = 2;

            var input2 = new int[] { 1, 1, 1, 1, 1, 1 };

            var input3 = new int[] { 4 };
            int day3 = 4;
            int month3 = 1;


            var result1 = birthday(input1.ToList<int>(), day1, month1);
            var result2 = birthday(input2.ToList<int>(), day1, month1);
            var result3 = birthday(input3.ToList<int>(), day3, month3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
