using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class Between2Sets
    {
        public static int getFactors(List<int> a,List<int> b)
        {
            int count=0;
            bool result = true;
            for(int i = 1; i <= 100; i++)
            {
                result = true;

                for(int j = 0; j < a.Count; j++)
                {
                    if (i % a[j] != 0)
                    {
                        result = false;
                        break;
                    }
                }

                for (int j = 0; j < b.Count; j++)
                {
                    if (b[j]%i != 0)
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    count++;
                }
            }

            return count;
        }

        public static void calculate()
        {
            var arr1 = new List<int>{ 2, 4 };
            var arr2 = new List<int> { 16,32,96 };

            Console.WriteLine(getFactors(arr1,arr2));

            arr1 = new List<int> { 2, 6 };
            arr2 = new List<int> { 24,36 };
            Console.WriteLine(getFactors(arr1, arr2));
        }

    }
}
