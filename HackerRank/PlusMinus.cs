using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class PlusMinus
    {
        public static void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }

        public static void plusMinus(List<int> arr)
        {
            double[] result = new double[3];
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                    negativeCount++;
                else if (arr[i] > 0)
                    positiveCount++;
                else
                    zeroCount++;
            }
            result[0] = (double)positiveCount / (double)arr.Count;
            result[1] = (double)negativeCount / (double)arr.Count;
            result[2] = (double)zeroCount / (double)arr.Count;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("{0:0.000000}",
                    result[i]);
            }

        }
    }
}
