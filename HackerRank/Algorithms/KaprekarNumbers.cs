using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class KaprekarNumbers
    {
        // Complete the kaprekarNumbers function below.
        static void kaprekarNumbers(int p, int q)
        {

            long numberSquare,l,r;
            string output = string.Empty;
            string numberStr, iStr;
            for(long i = p; i <= q; i++)
            {
                l = r = 0;
                numberSquare = i * i;
                numberStr = numberSquare.ToString();
                iStr = i.ToString();
                r = Convert.ToInt32(numberStr.Substring(numberStr.Length - iStr.Length));
                if (numberStr.Length - iStr.Length > 0)
                {
                    l = Convert.ToInt32(numberStr.Substring(0, numberStr.Length - iStr.Length));
                }

                if (l + r == i)
                {
                    output += i+" ";
                }

            }

            Console.WriteLine(output == string.Empty ? "INVALID RANGE" : output);


        }

        public static void calculate()
        {
            // kaprekarNumbers(5,5);
            // kaprekarNumbers(3,3);
            // kaprekarNumbers(9, 9);
            // kaprekarNumbers(1,1000000);
            // kaprekarNumbers(297, 297);
            kaprekarNumbers(400, 700);
        }
    }
}
