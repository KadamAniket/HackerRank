using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HackerRank
{
    public static class AppleAndOrange
    {
        //// Complete the countApplesAndOranges function below.
        //static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        //{
        //    int homeStart = s;
        //    int homeEnd = t;
        //    int appleTree = a;
        //    int orangeTree = b;
        //    int appleCount = 0, orangeCount = 0;
        //    int dropLocation = 0;

        //    Array.ForEach(apples, appleLocation =>
        //    {
        //        dropLocation = appleLocation + appleTree;
        //        if (dropLocation >= homeStart && dropLocation <= homeEnd) {
        //            appleCount++;
        //        }
        //    });

        //    Array.ForEach(oranges, appleLocation =>
        //    {
        //        dropLocation = appleLocation + orangeTree;
        //        if (dropLocation >= homeStart && dropLocation <= homeEnd)
        //        {
        //            orangeCount++;
        //        }
        //    });

        //    Console.WriteLine(appleCount);
        //    Console.WriteLine(orangeCount);

        //}

        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int homeStart = s;
            int homeEnd = t;
            int appleTree = a;
            int orangeTree = b;
            
            Console.WriteLine(countFruitInHome(apples,appleTree,homeStart,homeEnd));
            Console.WriteLine(countFruitInHome(oranges, orangeTree, homeStart, homeEnd));

        }


        private static int countFruitInHome(int[] fruitDropArray,int treeLocation,int homeStart,int homeEnd)
        {
            int count = 0, dropLocation = 0;
            Array.ForEach(fruitDropArray, fruitLocation =>
            {
                dropLocation = fruitLocation + treeLocation;
                if (dropLocation >= homeStart && dropLocation <= homeEnd)
                {
                    count++;
                }
            });

            return count;
        }

        public static void Calculate()
        {
            int s = 7;

            int t = 10;

            int a = 4;

            int b = 12;

            int[] apples = new int[] { 2, 3, -4 };

            int[] oranges = new int[] { 3, -2, -4 };

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
