﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/extra-long-factorials/problem

    public class ExtraLongFactorial
    {
        // Complete the extraLongFactorials function below.
        static void extraLongFactorials(int n)
        {
            int[] res = new int[500];

            // Initialize result 
            res[0] = 1;
            int res_size = 1;

            // Apply simple factorial formula  
            // n! = 1 * 2 * 3 * 4...*n 
            for (int x = 2; x <= n; x++)
                res_size = multiply(x, res,
                                    res_size);

            Console.WriteLine("Factorial of " +
                           "given number is ");
            for (int i = res_size - 1; i >= 0; i--)
                Console.Write(res[i]);

        }

        static int multiply(int x, int[] res,
                        int res_size)
        {
            int carry = 0; // Initialize carry 

            // One by one multiply n with  
            // individual digits of res[] 
            for (int i = 0; i < res_size; i++)
            {
                int prod = res[i] * x + carry;
                res[i] = prod % 10; // Store last digit of  
                                    // 'prod' in res[] 
                carry = prod / 10; // Put rest in carry 
            }

            // Put carry in res and 
            // increase result size 
            while (carry != 0)
            {
                res[res_size] = carry % 10;
                carry = carry / 10;
                res_size++;
            }
            return res_size;
        }

        public static void calculate() {

            extraLongFactorials(100);
        }
    }
}
