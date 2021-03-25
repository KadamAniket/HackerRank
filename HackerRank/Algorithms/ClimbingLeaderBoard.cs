using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class ClimbingLeaderBoard
    {
        // Complete the climbingLeaderboard function below.
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var result = new int[alice.Length];
            int rank;
            int j,count=scores.Length;


            for (int i = 0; i < alice.Length; i++)
            {
                rank = 1;
                for (j = 0; j < count; j++)
                {
                    if (alice[i] < scores[j])
                    {
                        if(j > 0 && scores[j] != scores[j - 1])
                        {
                            rank++;
                        }
                    }
                    else if(alice[i] > scores[0]){
                        rank = 0;
                        break;
                    }
                    else
                    {
                        break;
                    }
                                   
                }
                count = j;
                result[i] = rank+1;
            }

            return result;
        }

        public static void calculate()
        {
            var scores = new int[] { 100, 100, 50, 40, 40, 20, 10 };
            var aliceScores = new int[] { 5, 25, 50, 120 };

            var result = climbingLeaderboard(scores, aliceScores);
            Console.WriteLine(string.Join(" ", result));

            scores = new int[] { 100, 90,90,80,75,60 };
            aliceScores = new int[] { 50,65,77,90,102 };

            result = climbingLeaderboard(scores, aliceScores);

            Console.WriteLine(string.Join(" ", result));
        }

    }
}
