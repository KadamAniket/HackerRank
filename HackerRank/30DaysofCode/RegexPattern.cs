using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    // https://www.hackerrank.com/challenges/30-regex-patterns/problem

    public class RegexPattern
    {
        public static List<string> getMatchingEmails(List<string> inputList)
        {
            List<string> resultSet = new List<string>();

            foreach (string input in inputList)
            {
                if (input.EndsWith("@gmail.com"))
                {
                    resultSet.Add(input.Split(' ')[0]);
                }
            }

            resultSet.Sort();

            return resultSet;
        }

        public static void calculate()
        {
            var inputList = new List<string> { "riya riya@gmail.com",
                "julia julia@julia.me",
                "julia sjulia@gmail.com",
                "julia julia@gmail.com",
                "samantha samantha@gmail.com",
                "tanya tanya@gmail.com",};

            var result = getMatchingEmails(inputList);

            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
