using System;
using System.Collections.Generic;

namespace HackerRank
{
    class PermutingTwoArrays
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

        public static bool isQualified(int k, List<int> A, List<int> B)
        {
            int qualifiedCombinationsCount = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] >= k)
                    qualifiedCombinationsCount++;
            }
            if (qualifiedCombinationsCount == (A.Count))
                return true;
            return false;
        }

        static List<List<int>> permute(List<int> nums)
        {
            var list = new List<List<int>>();
            return doPermute(nums.ToArray(), 0, nums.Count - 1, list);
        }

        static List<List<int>> doPermute(int[] nums, int start, int end, List<List<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    swap(ref nums[start], ref nums[i]);
                    doPermute(nums, start + 1, end, list);
                    swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            var As = permute(A);
            var Bs = permute(B);
            for (int i = 0; i < As.Count; i++)
            {
                for (int j = 0; j < Bs.Count; j++)
                {
                    if (isQualified(k, As[i], Bs[j]))
                    {
                        return "YES";
                    }
                }
            }

            return "NO";
        }
    }
}
