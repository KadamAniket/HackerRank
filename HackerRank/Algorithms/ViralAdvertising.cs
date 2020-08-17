using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class ViralAdvertising
    {
        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {
            int sentToPeople = 5;
            int likedPeople;
            int totalLikePeople = 0;

            for(int i = 1; i <= n; i++)
            {
                likedPeople = sentToPeople / 2;
                totalLikePeople += likedPeople;
                sentToPeople = likedPeople * 3;

            }

            return totalLikePeople;
        }

        public static void calculate()
        {
            Console.WriteLine(viralAdvertising(3));
            Console.WriteLine(viralAdvertising(4));
            Console.WriteLine(viralAdvertising(5));
        }
    }
}
