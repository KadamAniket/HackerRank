using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class AngryProfessor
    {
        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a)
        {
            int studentArrivedOnTimeCount = 0;

            foreach(int studentArrivalTime in a)
            {
                if(studentArrivalTime <= 0)
                {
                    studentArrivedOnTimeCount++;
                }
            }

            return studentArrivedOnTimeCount >= k ? "NO" : "YES";

        }

        public static void calulate()
        {
            int threshold = 3;
            int[] studentArrivalTimes = new int[] { -1 ,- 3, 4, 2 };

            Console.WriteLine(angryProfessor(threshold,studentArrivalTimes));

            threshold = 2;
            studentArrivalTimes = new int[] { -1, 0, 4, 2 };

            Console.WriteLine(angryProfessor(threshold, studentArrivalTimes));
        }
    }
}
