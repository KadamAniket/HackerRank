using System;

// https://www.hackerrank.com/challenges/staircase/problem

namespace HackerRank
{
    public class Staircase
    {
        // Complete the staircase function below.
        void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > 0; j--)
                {
                    Console.Write(j > i ? " " : "#");
                }
                Console.WriteLine("d");
            }
        }


        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);


            Console.ReadLine();
        }
    }


}
