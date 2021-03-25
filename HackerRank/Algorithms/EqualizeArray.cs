using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class EqualizeArray
    {
        // Complete the equalizeArray function below.
        static int equalizeArray(int[] arr)
        {
            int maxRecurringELement = getMaxRecurringElement(arr);

            return arr.Length - maxRecurringELement;

        }

        private static int getMaxRecurringElement(int[] arr)
        {
            int maxCount = 0, count;
            for(int i = 0; i < arr.Length; i++)
            {
                count = 1;
                for(int j=i+1;j< arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if(count> maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }

        public static void calculate()
        {
            var input = new int[] { 3, 3, 2, 1, 3 };
            Console.WriteLine(equalizeArray(input));
            input = new int[] { 1,2,2,3,4,4,4 };
            Console.WriteLine(equalizeArray(input));

            input = new int[] { 24, 29, 70, 43, 12, 27, 29, 24, 41, 12, 41, 43, 24, 70, 24, 100, 41, 43, 43, 100,
                29, 70, 100, 43, 41, 27, 70, 70, 59, 41, 24, 24, 29, 43, 24, 27, 70, 24, 27, 70, 24, 70, 27, 24, 43,
                27, 100, 41, 12, 70, 43, 70, 62, 12, 59, 29, 62, 41, 100,
                43, 43, 59, 59, 70, 12, 27, 43, 43, 27, 27, 27, 24, 43, 43, 62, 43, 70, 29 };
            Console.WriteLine(equalizeArray(input));
        }
    }
}
