using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    public class SockMerchant
    {
        public void calculatePair() {

            //int[] arr = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int[] arr = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

            int[] ar = Array.ConvertAll(("1 1 3 1 2 1 3 3 3 3").Split(' '), tar => Convert.ToInt32(tar));

            var result=  sockMerchant(arr.Length, arr);

            Console.WriteLine("Result: {0}", result);
        }

        private int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int pairCount = 0;
            foreach (int num in ar)
            {
                if (dict.ContainsKey(num))
                {
                    pairCount++;
                    dict.Remove(num);
                }
                else
                {
                    dict.Add(num, num);
                }
            }

            return pairCount;
        }
    }
}
