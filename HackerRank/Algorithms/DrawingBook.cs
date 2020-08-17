using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    // https://www.hackerrank.com/challenges/drawing-book/problem
    public class DrawingBook
    {

        static int pageCount(int n, int p)
        {
            // Complete this function
            int total = n / 2;
            int right = p / 2;
            int left = total - right;
            return right < left ? right : left;
            
        }

        public static void calculate()
        {
            int bookPageCount = 6;
            int pageToNavigate = 2;

            Console.WriteLine(pageCount(bookPageCount, pageToNavigate));
            Console.WriteLine(pageCount(5, 4));
        }

    }
}
