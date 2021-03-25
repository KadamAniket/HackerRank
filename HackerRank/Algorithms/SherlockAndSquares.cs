using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class SherlockAndSquares
    {
        static int squares(int a, int b)
        {
            int count = 0;
            int x1 = (int)Math.Ceiling(Math.Sqrt(a));
            int x2 = (int)Math.Floor(Math.Sqrt(b));

            if ((x2 - x1 + 1) > 0)
            {
                count = x2 - x1 + 1;
            }

            return count;

        }

        //static int squares(int a, int b)
        //{
        //    int squareNumberCount = 0;

        //    for(int i = a; i <= b; i++)
        //    {
        //        if (square_root(i))
        //        {
        //            squareNumberCount++;
        //            i = i * 2;
        //        }
        //    }

        //    return squareNumberCount;

        //}

        private static bool square_root(int x)
        {
            const double difference = 0.00001f;
            double guess = 1.0f;
            while (Math.Abs(guess * guess - x) >= difference)
            {
                guess = (x / guess + guess) / 2.0;
            }

            return Math.Round(guess, 2) % 1 == 0;
        }

        private static bool isSquare(int num)
        {
            if (num == 1)
                return true;

            for (int i = 1; i <= num / 2; i++)
            {
                if (i * i == num)
                {
                    return true;
                }

                if (i * i > num)
                {
                    return false;
                }
            }

            return false;
        }

        public static void calculate()
        {
            Console.WriteLine(squares(3, 9));
            Console.WriteLine(squares(17, 24));
            Console.WriteLine(squares(1, 100));
            //Console.WriteLine(DateTime.Now);
            // Console.WriteLine(squares(1, 1000000000));
            //Console.WriteLine(DateTime.Now);
        }
    }
}
