using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    public class BitwiseAnd
    {
        static int getMaxAndValue(int n,int k)
        {
            int maxValue = 0;
            int operValue;

            for(int i = 1; i < n; i++)
            {
                for(int j = i + 1; j <= n; j++)
                {
                    operValue = (i & j);
                    if (operValue > maxValue && operValue < k)
                    {
                        maxValue = operValue;
                    }
                }
            }

            return maxValue;
        }

        public static void calculate() {
            Console.WriteLine(getMaxAndValue(5,2)); 
        }



    }
}
