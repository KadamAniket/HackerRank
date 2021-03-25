using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class CamelCase
    {
        static int camelcase(string s)
        {
            int counter = 1;
            foreach(char c in s)
            {
                if (char.IsUpper(c))
                {
                    counter++;
                }
            }


            return counter;

        }

        public static void calculate()
        {
            Console.WriteLine(camelcase("oneTwoThreeFourFive"));
        }
    }
}
