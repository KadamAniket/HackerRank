using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class GradingStudents
    {
        private static List<int> gradingStudents(List<int> grades)
        {
            var newResult = new List<int>();
            grades.ForEach(grade =>
            {
                int nextNumber = grade + (5 - grade % 5);
                newResult.Add((grade >= 38 && nextNumber - grade < 3) ? nextNumber : grade);
            });

            return newResult;
        }

        public static void Calculate()
        {
            List<int> grades = new List<int> { 73, 67, 38, 33,0,100,99,37 };

            List<int> result = gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}
