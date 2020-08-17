using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class BeautifulTriplets
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            int counter = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    for(int k=j+1;k<arr.Length; k++)
                    {
                        if ((arr[j] - arr[i] == arr[k] - arr[j]) && (arr[k] - arr[j] == d)) {
                            counter++;
                        }
                    }
                }
            }


            return counter;

        }


        static int beautifulTripletsOptimize(int d, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] > d)
                        break;

                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[k] - arr[j] > d)
                            break;

                        if ((arr[j] - arr[i] == arr[k] - arr[j]) && (arr[k] - arr[j] == d))
                        {
                            counter++;
                        }
                    }
                }
            }


            return counter;

        }

        public static void calculate()
        {
            Console.WriteLine(beautifulTripletsOptimize(1,new int[] { 2,2,3,4,5}));
            Console.WriteLine(beautifulTripletsOptimize(3, new int[] { 1,2,4,5,7,8,10 }));
            var input = new int[10000];
            for(int i = 0; i < 10000; i++)
            {
                input[i] = i + 1;
            }

           //  Console.WriteLine(beautifulTriplets(3, input));

            var dt = DateTime.Now;
            Console.WriteLine(beautifulTripletsOptimize(3, input));
            Console.WriteLine(DateTime.Now.Subtract(dt).Milliseconds);


        }
    }
}
