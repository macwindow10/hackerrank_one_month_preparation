using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class FlippingBits
    {
        public static void execute()
        {
            List<int> queries = new List<int>();

            queries.AddRange(new int[] { 2147483647, 1, 0 });
            for (int qItr = 0; qItr < queries.Count; qItr++)
            {
                long result = flippingBits(queries[qItr]);
            }
        }

        public static long flippingBits(long n)
        {
            int i = 1;
            while (i <= 32)
            {
                n = n ^ (1 << i);
                i++;
            }
            uint r = (uint)n; 
            Console.WriteLine(r);
            return r;
        }

    }
}
