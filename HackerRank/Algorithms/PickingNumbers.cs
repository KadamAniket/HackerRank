using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {
            int maxListCount = 0;
            int count;
            int sameElement= 0;

            a.Sort();

            for(int i = 0; i < a.Count; i++)
            {
                count = 1;
                if (a[i] == sameElement)
                {
                    continue;
                }
                else
                {
                    sameElement = a[i];
                }
                for (int j = i+1; j < a.Count; j++)
                {
                    if(Math.Abs(a[i] - a[j]) <= 1)
                    {
                        count++;
                    }
                }
                if(count > maxListCount)
                {
                    maxListCount = count;
                }
                
            }

            return maxListCount;
        }

        public static void calculate()
        {
            var list = new List<int> { 4, 6, 5, 3, 3, 1 };

            Console.WriteLine(pickingNumbers(list));

            list=new List<int>{ 1,1,2,2,4,4,5,5,5 };

            Console.WriteLine(pickingNumbers(list));

        }
    }
}
