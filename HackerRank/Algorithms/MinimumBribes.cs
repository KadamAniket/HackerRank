using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    public class MinimumBribes
    {
        public void calculateMinimumBribe()
        {
            int[] q =new int[] { 2, 1, 5, 3, 4 };

            var miniumBribe = minimumBribes(q);

            Console.WriteLine("Minimum Bribes: {0}", miniumBribe);
        }

        private int minimumBribes(int[] q)
        {
            int minimumBribes = 0;

            for (int i = 0; i < q.Length; i++) {
                if (i + 1 == q[i])
                {
                    continue;
                }
                else if (q[i] < i + 1 ) {
                    minimumBribes++;
                }

            }

            return minimumBribes;

        }
    }
}
