using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class LibraryFine
    {
        // Complete the libraryFine function below.
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = 0;

            // Same year
            if(y1==y2)
            {
                if (m1 == m2)
                {
                    // Late return
                    if (d2 < d1)
                    {
                        fine = 15 * (d1 - d2);
                    }
                }
                else if(m1 > m2)
                {
                    fine = (m1 - m2) * 500;
                }
            }
            else if(y1 > y2)
            {
                fine = 10000;
            }


            return fine;

        }

        public static void calculate()
        {
            //Console.WriteLine(libraryFine(9, 6, 2015, 6, 6, 2015));
            //Console.WriteLine(libraryFine(9, 7, 2015, 6, 6, 2015));
            //Console.WriteLine(libraryFine(9, 6, 2016, 6, 6, 2015));
            //Console.WriteLine(libraryFine(9, 6, 2015, 9, 6, 2015));
            //Console.WriteLine(libraryFine(6, 6, 2015, 7, 6, 2015));

            // Console.WriteLine(libraryFine(6, 6, 2015, 9, 6, 2016));
            // Console.WriteLine(libraryFine(2, 7, 1014, 1,1,1015));

            Console.WriteLine(libraryFine(28,2,2015,15,4,2015));
        }
    }
}
