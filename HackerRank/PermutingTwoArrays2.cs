using System;
using System.Collections.Generic;

namespace HackerRank
{
    class PermutingTwoArrays2
    {
        public static void execute()
        {
            List<int> A = new List<int>();
            A.AddRange(new int[] { 2, 1, 3 });

            List<int> B = new List<int>();
            B.AddRange(new int[] { 7, 8, 9 });

            string result = twoArrays(10, A, B);
            Console.WriteLine(result);


            A = new List<int>();
            A.AddRange(new int[] { 1, 2, 2, 1 });

            B = new List<int>();
            B.AddRange(new int[] { 3, 3, 3, 4 });

            result = twoArrays(5, A, B);
            Console.WriteLine(result);
        }

        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();
            int i, j;
            for (i = 0, j = A.Count - 1; i < A.Count; i++, j--)
            {
                if (A[i] + B[j] < k)
                {
                    return "NO";
                }
            }
            return "YES";
        }
    }
}
