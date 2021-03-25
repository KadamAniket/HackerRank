using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            long repeatedCount;
            long occuranceCount = getOccurances(s, 'a');
            if (n % s.Length == 0)
            {
                repeatedCount = occuranceCount * (n / s.Length);
            }
            else
            {
                repeatedCount = occuranceCount * (n / s.Length) +
                    getOccurances(s.Substring(0, Convert.ToInt32(n % s.Length)), 'a');
            }

            return repeatedCount;

        }

        private static int getOccurances(string s, char a)
        {
            int occurance = 0;

            foreach (char c in s)
            {
                if (c == a)
                {
                    occurance++;
                }
            }

            return occurance;
        }

        public static void calculate()
        {
            Console.WriteLine(repeatedString("abcac",10));
            Console.WriteLine(repeatedString("aba", 10));
            Console.WriteLine(repeatedString("a", 1000000000000));

            Console.WriteLine(repeatedString("aab", 882787));
        }
    }
}
