using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class SaveThePrisoner
    {
        // Complete the saveThePrisoner function below.
        static int saveThePrisoner(int n, int m, int s)
        {
            if (n >= m)
                return s + m - 1;
            else
                return  (m % n)+s-1;

        }

        public static void calculate()
        {
            //Console.WriteLine(saveThePrisoner(5,2,1));
            //Console.WriteLine(saveThePrisoner(5, 2, 2));
            //Console.WriteLine(saveThePrisoner(7, 19, 2));
            //Console.WriteLine(saveThePrisoner(3, 7, 3));
            Console.WriteLine(saveThePrisoner(46934, 543563655, 46743));
            
        }
    }
}
