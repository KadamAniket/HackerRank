using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1._30DaysOfCode
{
    public class BinaryNumbers
    {
        static int ConvertDecimalToBinary(int num)
        {
            int remainder;
            string result = string.Empty;
            int count = 0,maxCount=0;


            while(num > 0)
            {
                remainder = num % 2;
                result += remainder;
                num = num / 2;

                if(remainder == 1)
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    count++;
                }
                else
                {
                    count = 0;
                }

             
            }

            Console.WriteLine(string.Join("",result.Reverse()));

            return maxCount;
        }

        public static void calculate()
        {
            Console.WriteLine(ConvertDecimalToBinary(439));
            //Console.WriteLine(ConvertDecimalToBinary(5));
            //Console.WriteLine(ConvertDecimalToBinary(6));
        }
    }
}
