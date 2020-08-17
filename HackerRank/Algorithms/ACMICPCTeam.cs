using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms
{
    // https://www.hackerrank.com/challenges/acm-icpc-team/problem

    public class ACMICPCTeam
    {
        // Complete the acmTeam function below.
        static int[] acmTeam(string[] topic)
        {
            int subjectCount = topic[0].Length;
            var maxSubject = new int[subjectCount];
            int topicCount;
            for(int i = 0; i < topic.Length - 1; i++)
            {
                for(int j=i+1;j< topic.Length; j++)
                {
                    topicCount = 0;

                    for (int count = 0; count < subjectCount; count++)
                    {
                        if(topic[i][count] == '1' || topic[j][count] == '1')
                        {
                            topicCount++;
                        }
                    }

                    maxSubject[topicCount - 1]++;
                }

                
            }

            var result = new int[2];
            for(int i=maxSubject.Length - 1; i >= 0; i--)
            {
                if(maxSubject[i] > 0)
                {
                    result[0] = i + 1;
                    result[1] = maxSubject[i];
                    break;
                }
            }

            return result;

        }

        static int[] acmTeamOptimize(string[] topic)
        {
            int subjectCount = topic[0].Length;
            int topicCount;
            int maxTopicCovered = 0;
            int pairCount = 0;
            for (int i = 0; i < topic.Length - 1; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    topicCount = 0;

                    for (int count = 0; count < subjectCount; count++)
                    {
                        if (topic[i][count] == '1' || topic[j][count] == '1')
                        {
                            topicCount++;
                        }
                    }

                    if(topicCount > maxTopicCovered)
                    {
                        maxTopicCovered = topicCount;
                        pairCount = 1;
                    }else if(topicCount == maxTopicCovered)
                    {
                        pairCount++;
                    }
                }


            }

            return new int[2] { maxTopicCovered,pairCount };

        }

        public static void calculate()
        {
            var input = new string[] { "10101", "11110", "00010" };
            var result = acmTeamOptimize(input);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

            input = new string[] { "10101", "11100", "11010", "00101" };
            result = acmTeamOptimize(input);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

        }
    }
}
