using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class ElectronicShop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int amount=-1;
            for(int i = 0; i < keyboards.Length; i++)
            {
                for(int j=0;j< drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] > amount && keyboards[i] + drives[j] <= b)
                    {
                        amount = keyboards[i] + drives[j];
                    }
                }
            }

            return amount;

        }

        public static void calculate()
        {
            var keyboards = new int[] { 3, 1 };
            var drives = new int[] { 5, 2,8};
            var budget = 10;

            Console.WriteLine(getMoneySpent(keyboards,drives,budget));

            keyboards = new int[] {4 };
            drives = new int[] { 5  };
            budget = 5;

            Console.WriteLine(getMoneySpent(keyboards, drives, budget));
        }
    }
}
