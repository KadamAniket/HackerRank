using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    // https://www.hackerrank.com/challenges/array-left-rotation/problem

    public class LeftRotation
    {
        public static int[] shiftArray(int[] arr, int shiftCount)
        {
            int firstElement = 0;
            for (int counter = 0; counter < shiftCount; counter++)
            {
                firstElement = arr[0];
                for (int shift = 0; shift < arr.Length - 1; shift++)
                {
                    arr[shift] = arr[shift + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }
            return arr;
        }

        public static int[] shiftArrayWithSingleLoop(int[] arr, int shiftCount)
        {
            int[] shiftedArr = new int[arr.Length];
            int newloc = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newloc = i - shiftCount;
                if (newloc < 0)
                    newloc = arr.Length + newloc;
                shiftedArr[newloc] = arr[i];
            }

            return shiftedArr;
        }

        public static int[] shiftArraySimplified(int[] arr, int shiftCount)
        {
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[(i + arr.Length - shiftCount) % arr.Length] = arr[i];
            }

            return result;
        }

        public static void calculate()
        {
            var datetime = DateTime.Now;
            //int count = 10000;
            //var ar = new int[count];
            //for (int i=0;i< count; i++)
            //{
            //    ar[i] = i + 1;
            //}

            //Console.WriteLine(string.Join(' ', shiftArray(ar, 1000)));

            var ar = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(' ', shiftArrayWithSingleLoop(ar, 4)));


            Console.WriteLine(DateTime.Now.Subtract(datetime));

        }
    }
}
