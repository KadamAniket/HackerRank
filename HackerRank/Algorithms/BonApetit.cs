using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/bon-appetit/problem
    public class BonApetit
    {
        static void bonAppetit(List<int> bill, int k, int b)
        {
            // Solution 1
            //int totalAmount = 0;
            //for (int i = 0; i < bill.Count; i++)
            //{
            //    if (i != k)
            //    {
            //        totalAmount += bill[i];
            //    }
            //}

            //int actualCharge = totalAmount / 2;


            // Solution 2
            var totalAmount = bill.Sum();
            var actualAmount = totalAmount - bill[k];
            int actualCharge = actualAmount / 2;

            if (actualCharge == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - actualCharge);
            }
        }

        public static void calculate()
        {
            List<int> bill = new List<int> { 3, 10, 2, 9 };

            bonAppetit(bill, 1, 12);

            bonAppetit(bill, 1, 7);

        }

    }
}
