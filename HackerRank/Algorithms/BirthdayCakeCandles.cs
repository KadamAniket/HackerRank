using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank
{
    public static class BirthdayCakeCandles
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int candlesToBlow = 0;
            Int64 maxNumber = ar[0];

            for (int i = 1; i < ar.Length; i++)
            {
                maxNumber = ar[i] > maxNumber ? ar[i] : maxNumber;
            }

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == maxNumber)
                {
                    candlesToBlow++;
                }
            }

            return candlesToBlow;

        }

        public static void Calculate()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[] { 3, 2, 1, 3 };
            int result = birthdayCakeCandles(ar);


            Console.WriteLine(result);


        }
    }
}
