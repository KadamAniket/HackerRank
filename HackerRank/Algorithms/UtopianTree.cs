using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class UtopianTree
    {
        // Complete the utopianTree function below.
        static int utopianTree(int n)
        {
            int height = 1;

            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    height = height * 2;
                }
                else
                {
                    height++;
                }
            }

            return height;

        }

        public static void calculate()
        {
            Console.WriteLine(utopianTree(0));
            Console.WriteLine(utopianTree(1));
            Console.WriteLine(utopianTree(4));
            Console.WriteLine(utopianTree(60));
        }
    }
}
