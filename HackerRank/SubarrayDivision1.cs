using System;
using System.Collections.Generic;

namespace HackerRank
{
    class SubarrayDivision1
    {
        public static void execute()
        {
            List<int> A = new List<int>();
            A.AddRange(new int[] { 2, 2, 1, 3, 2 });
            int result = birthday(A, 4, 2);
            Console.WriteLine(result);
        }

        public static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; (i + m) <= s.Count; i++)
            {
                var segment = new ArraySegment<int>(s.ToArray(), i, m);
                //Console.WriteLine("{0}: {1}", i, string.Join("", segment));
                var subarray = segment.ToArray();
                int sum = 0;
                for (int j = 0; j < subarray.Length; j++)
                {
                    sum = sum + subarray[j];
                }
                if (sum == d)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
