using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class MiniMaxSum
    {
        public static void execute()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            uint mini = 0;
            uint max = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i != 0)
                {
                    max = max + (uint)arr[i];
                }

                if (i != (arr.Count - 1))
                {
                    mini = mini + (uint)arr[i];
                }
            }
            Console.WriteLine("{0} {1}", mini, max);
        }
    }
}
