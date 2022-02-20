using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class DiagonalDifference
    {
        public static void execute()
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> A = new List<int>();
            A.AddRange(new int[] { 11, 2, 4 });
            arr.Add(A);

            A = new List<int>();
            A.AddRange(new int[] { 4, 5, 6 });
            arr.Add(A);

            A = new List<int>();
            A.AddRange(new int[] { 10, 8, -12 });
            arr.Add(A);

            int result = diagonalDifference(arr);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[0].Count; j++)
                {
                    if (i == j)
                    {
                        sum1 = sum1 + arr[i][j];
                    }

                    if (i == arr.Count - j - 1)
                    {
                        sum2 = sum2 + arr[i][j];
                    }
                }
            }
            result = Math.Abs(sum1 - sum2);
            return result;
        }
    }
}
