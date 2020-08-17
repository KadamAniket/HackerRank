using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Stack
{
    class Operation
    {
        public int value;
        public int operation;
    }
    // https://www.hackerrank.com/challenges/maximum-element/problem
    public class MaximumElement
    {
        public static void calculate()
        {
            List<int> stack = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            string output = string.Empty;

            for(int i = 0; i < n; i++)
            {
                var operationArr = Console.ReadLine().Split(' ');
                switch (Convert.ToInt32(operationArr[0]))
                {
                    case 1:
                        stack.Insert(0, Convert.ToInt32(operationArr[1]));
                        break;

                    case 2:
                        stack.RemoveAt(0);
                        break;

                    case 3:
                        output += stack.Max() + "\n";
                        break;
                }
            }
            Console.WriteLine(output);

            
        }
    }
}
