using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class CatsAndMouse
    {
        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            int cat1Dist = Math.Abs(z - x);
            int cat2Dist =Math.Abs(z - y);
            if(cat1Dist < cat2Dist)
            {
                return "Cat A";
            }else if (cat1Dist > cat2Dist)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }

        }

        public static void calculate()
        {
            Console.WriteLine(catAndMouse(1, 5, 2));
            Console.WriteLine(catAndMouse(1, 2, 3));
            Console.WriteLine(catAndMouse(1, 3, 2));
        }
    }
}
