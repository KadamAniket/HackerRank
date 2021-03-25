using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp1.Algorithms
{
    public class SequenceEquation
    {
        // Complete the permutationEquation function below.
        static int[] permutationEquation(int[] p)
        {
            var result = new int[p.Length];
            for(int i = 0; i < p.Length; i++)
            {
                result[i] = findIndex(p, findIndex(p, i+1));
            }

            return result;
        }

        private static int findIndex(int[] p,int val)
        {
            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] == val)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        public static void calculate()
        {
            var input = new int[] { 5,2,1,3,4 };
            var result = permutationEquation(input);
            Console.WriteLine(String.Join(" ", result));

            input = new int[] { 2,3,1};
            result= permutationEquation(input);
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
