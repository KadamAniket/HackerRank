using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pattern
    {
        public static void printPattern(int n)
        {
            int size = n * 2 - 1;
            var arr = new int[size,size];
            int count=0;

            while (n > 0)
            {

                for (int i = count; i < size - count; i++)
                {
                    arr[i, size - 1 - count] = n;
                    arr[i, count] = n;
                    arr[count, i] = n;
                    arr[size - 1 - count, i] = n;
                }
                count++;
                n--;
            }


            // Display
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
            }

        }
    }
}
